﻿' (c) 2019 Daniel Van Noord
' This code is licensed under MIT license (see License.txt for details)

Imports System
Imports System.Collections.Generic
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json


'This namespace dual targets NetStandard2.0 and Net35, thus no async await
Friend Class Finder
    Implements IDisposable

    Private TL As TraceLogger
    Private ReadOnly callbackFunctionDelegate As Action(Of IPEndPoint, AlpacaDiscoveryResponse)
    Private ReadOnly udpClient As UdpClient

    Dim ipV6Discoveryclients As List(Of UdpClient) = New List(Of UdpClient)()

    ''' <summary>
    ''' A cache of all endpoints found by the server
    ''' </summary>
    Public ReadOnly Property CachedEndpoints As List(Of IPEndPoint) = New List(Of IPEndPoint)()

#Region "Initialisation and Dispose"
    ''' <summary>
    ''' Creates a Alpaca Finder object that sends out a search request for Alpaca devices
    ''' The results will be sent to the callback and stored in the cache
    ''' Calling search and concatenating the results reduces the chance that a UDP packet is lost
    ''' This may require firewall access
    ''' </summary>
    ''' <param name="callback">A callback function to receive the endpoint result</param>
    Friend Sub New(ByVal callback As Action(Of IPEndPoint, AlpacaDiscoveryResponse), ByVal traceLogger As TraceLogger)
        TL = traceLogger ' Save the trace logger object
        LogMessage("Finder", "Starting Initialisation...")
        callbackFunctionDelegate = callback
        udpClient = New UdpClient()
        udpClient.EnableBroadcast = True
        udpClient.MulticastLoopback = False

        '0 tells OS to give us a free ethereal port
        udpClient.Client.Bind(New IPEndPoint(IPAddress.Any, 0))
        udpClient.BeginReceive(New AsyncCallback(AddressOf FinderDiscoveryCallback), udpClient)
        LogMessage("Finder", "Initialised")
    End Sub

    Private disposedValue As Boolean = False ' To detect redundant calls

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not disposedValue Then

            If disposing Then

                If udpClient IsNot Nothing Then

                    Try
                        udpClient.Close()
                    Catch
                    End Try
                End If

                For Each client As UdpClient In ipV6Discoveryclients
                    Try : client.Close() : Catch : End Try
                Next

                'try { udpClient.Dispose(); } catch { }
            End If

            disposedValue = True
        End If
    End Sub

    ' This code added to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put clean-up code in Dispose(bool disposing) above.
        Dispose(True)
    End Sub

#End Region

#Region "Public methods"

    ''' <summary>
    ''' Resends the search request
    ''' </summary>
    Public Sub Search(ByVal discoveryport As Integer, ipV4Enabled As Boolean, ipV6Enabled As Boolean)
        If ipV4Enabled Then SendDiscoveryMessageIpV4(discoveryport)
        If ipV6Enabled Then SendDiscoveryMessageIpV6(discoveryport)
    End Sub

    ''' <summary>
    ''' Clears the cached IP Endpoints in CachedEndpoints
    ''' </summary>
    Public Sub ClearCache()
        CachedEndpoints.Clear()
    End Sub

#End Region

    Private Sub SendDiscoveryMessageIpV4(ByVal discoveryPort As Integer)
        Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        LogMessage("SendDiscoveryMessageIpV4", $"Sending IPv$ discovery broadcasts")

        For Each adapter As NetworkInterface In adapters
            'Do not try and use non-operational adapters
            If adapter.OperationalStatus <> OperationalStatus.Up Then Continue For

            If adapter.Supports(NetworkInterfaceComponent.IPv4) Then
                Dim adapterProperties As IPInterfaceProperties = adapter.GetIPProperties()
                If adapterProperties Is Nothing Then Continue For
                Dim uniCast As UnicastIPAddressInformationCollection = adapterProperties.UnicastAddresses

                If uniCast.Count > 0 Then

                    For Each uni As UnicastIPAddressInformation In uniCast
                        If uni.Address.AddressFamily <> AddressFamily.InterNetwork Then Continue For

                        ' Local host addresses (127.*.*.*) may have a null mask in Net Framework. We do want to search these. The correct mask is 255.0.0.0.
                        udpClient.Send(Encoding.ASCII.GetBytes(DISCOVERY_MESSAGE), Encoding.ASCII.GetBytes(DISCOVERY_MESSAGE).Length, New IPEndPoint(GetBroadcastAddress(uni.Address, If(uni.IPv4Mask, IPAddress.Parse("255.0.0.0"))), discoveryPort))
                        LogMessage("SendDiscoveryMessageIpV4", $"Sent broadcast to: {uni.Address}")
                    Next
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Send out discovery message on the IPv6 multicast group
    ''' This dual targets NetStandard 2.0 and NetFX 3.5 so no Async Await
    ''' </summary>
    Private Sub SendDiscoveryMessageIpV6(ByVal discoveryPort As Integer)

        For Each client As UdpClient In ipV6Discoveryclients
            Try : client.Close() : Catch : End Try
        Next

        ipV6Discoveryclients.Clear()

        LogMessage("SendDiscoveryMessageIpV6", $"Sending IPv6 discovery broadcasts")

        ' Windows needs to bind a socket to each adapter explicitly
        For Each adapter As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            LogMessage("SendDiscoveryMessageIpV6", $"Found network interface {adapter.Description}, Interface type: {adapter.NetworkInterfaceType} - supports multicast: {adapter.SupportsMulticast}")
            If adapter.OperationalStatus <> OperationalStatus.Up Then Continue For
            LogMessage("SendDiscoveryMessageIpV6", $"Interface is up")

            If adapter.Supports(NetworkInterfaceComponent.IPv6) AndAlso adapter.SupportsMulticast Then
                LogMessage("SendDiscoveryMessageIpV6", $"Interface supports IPv6")
                Dim adapterProperties As IPInterfaceProperties = adapter.GetIPProperties()
                If adapterProperties Is Nothing Then Continue For
                Dim uniCast As UnicastIPAddressInformationCollection = adapterProperties.UnicastAddresses
                LogMessage("SendDiscoveryMessageIpV6", $"Adapter does have properties. Number of unicast addresses: {uniCast.Count}")

                If uniCast.Count > 0 Then

                    For Each uni As UnicastIPAddressInformation In uniCast
                        If uni.Address.AddressFamily = AddressFamily.InterNetworkV6 Then
                            LogMessage("SendDiscoveryMessageIpV6", $"Interface is IPv6")

                            Try
                                Dim client As UdpClient = New UdpClient(AddressFamily.InterNetworkV6)

                                '0 tells OS to give us a free ethereal port
                                client.Client.Bind(New IPEndPoint(uni.Address, 0))
                                client.BeginReceive(New AsyncCallback(AddressOf FinderDiscoveryCallback), client)
                                client.Send(Encoding.ASCII.GetBytes(DISCOVERY_MESSAGE), Encoding.ASCII.GetBytes(DISCOVERY_MESSAGE).Length, New IPEndPoint(IPAddress.Parse(ALPACA_DISCOVERY_IPV6_MULTICAST_ADDRESS), discoveryPort))
                                LogMessage("SendDiscoveryMessageIpV6", $"Sent multicast IPv6 discovery packet")

                                ipV6Discoveryclients.Add(client)
                            Catch ex As SocketException
                            End Try
                        End If
                    Next
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' This callback is shared between IPv4 and IPv6
    ''' </summary>
    ''' <param name="ar"></param>
    Private Sub FinderDiscoveryCallback(ByVal ar As IAsyncResult)
        Try
            Dim udpClient As UdpClient = CType(ar.AsyncState, UdpClient)
            Dim alpacaBroadcastResponseEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, DEFAULT_DISCOVERY_PORT)

            ' Obtain the UDP message body and convert it to a string, with remote IP address attached as well
            Dim ReceiveString As String = Encoding.ASCII.GetString(udpClient.EndReceive(ar, alpacaBroadcastResponseEndPoint))
            LogMessage($"FinderDiscoveryCallback", $"Received {ReceiveString} from Alpaca device at {alpacaBroadcastResponseEndPoint.Address}")

            ' Configure the UdpClient class to accept more messages, if they arrive
            udpClient.BeginReceive(New AsyncCallback(AddressOf FinderDiscoveryCallback), udpClient)

            'Only process Alpaca device responses
            If ReceiveString.ToLowerInvariant().Contains(DISCOVERY_RESPONSE_STRING) Then
                ' Extract the discovery response parameters from the device's JSON response
                Dim discoveryResponse As AlpacaDiscoveryResponse = JsonConvert.DeserializeObject(Of AlpacaDiscoveryResponse)(ReceiveString)
                Dim alpacaApiEndpoint As IPEndPoint = New IPEndPoint(alpacaBroadcastResponseEndPoint.Address, discoveryResponse.AlpacaPort) ' Create 
                If Not CachedEndpoints.Contains(alpacaApiEndpoint) Then
                    CachedEndpoints.Add(alpacaApiEndpoint)
                    LogMessage("FinderDiscoveryCallback", $"Received new Alpaca API endpoint: {alpacaApiEndpoint} from broadcast endpoint: {alpacaBroadcastResponseEndPoint}")
                    callbackFunctionDelegate?.Invoke(alpacaApiEndpoint, discoveryResponse) ' Moved inside the loop so that the callback is only called once per IP address
                Else
                    LogMessage("FinderDiscoveryCallback", $"Ignoring duplicate Alpaca API endpoint: {alpacaApiEndpoint} from broadcast endpoint: {alpacaBroadcastResponseEndPoint}")
                End If
            End If

            ' Ignore these, they can occur after the Finder is disposed
        Catch __unusedObjectDisposedException1__ As ObjectDisposedException
        Catch ex As Exception
            LogMessage("FinderDiscoveryCallback", $"Exception: " & ex.ToString())
        End Try
    End Sub


    ' This turns the unicast address and the subnet into the broadcast address for that range
    ' http://blogs.msdn.com/b/knom/archive/2008/12/31/ip-address-calculations-with-c-subnetmasks-networks.aspx
    Private Shared Function GetBroadcastAddress(ByVal address As IPAddress, ByVal subnetMask As IPAddress) As IPAddress
        Dim ipAdressBytes As Byte() = address.GetAddressBytes()
        Dim subnetMaskBytes As Byte() = subnetMask.GetAddressBytes()
        If ipAdressBytes.Length <> subnetMaskBytes.Length Then Throw New ArgumentException("Lengths of IP address and subnet mask do not match.")
        Dim broadcastAddress As Byte() = New Byte(ipAdressBytes.Length - 1) {}

        For i As Integer = 0 To broadcastAddress.Length - 1
            broadcastAddress(i) = CByte(ipAdressBytes(i) Or (subnetMaskBytes(i) Xor 255))
        Next

        Return New IPAddress(broadcastAddress)
    End Function

    Private Sub LogMessage(ByVal method As String, ByVal message As String)
        If Not TL Is Nothing Then
            Dim indentSpaces As String = New [String](" "c, Thread.CurrentThread.ManagedThreadId * NUMBER_OF_THREAD_MESSAGE_INDENT_SPACES)
            TL.LogMessage($"Finder - {method}", $"{indentSpaces}{Thread.CurrentThread.ManagedThreadId} - {message}")
        End If
    End Sub
End Class
