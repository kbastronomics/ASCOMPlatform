﻿'Public and private interfaces for the ASCOM.Utilities namespace

Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Net

Namespace Interfaces

#Region "Utilities Public Interfaces"

    ''' <summary>
    ''' Methods visible to both COM and .NET clients
    ''' </summary>
    <Guid("2299465C-A42B-47FE-B8F5-B3A1AF11B137"), ComVisible(True)>
    Public Interface IAlpacaDevice
        ''' <summary>
        ''' The Alpaca device's DNS host name, if available, otherwise its IP address. IPv6 addresses will be in canonical form.
        ''' </summary>
        <DispId(1)> Property HostName As String

        ''' <summary>
        ''' The Alpaca device's IP address. IPv6 addresses will be in canonical form.
        ''' </summary>
        <DispId(2)> Property IpAddress As String

        ''' <summary>
        ''' Alpaca device's IP port number
        ''' </summary>
        <DispId(3)> Property Port As Integer

        ''' <summary>
        ''' Array of ASCOM devices available on this Alpaca device
        ''' </summary>
        <DispId(4)> ReadOnly Property ConfiguredDevicesAsArrayList As ArrayList

        ''' <summary>
        ''' Array of supported Alpaca interface version numbers
        ''' </summary>
        <DispId(5)> Property SupportedInterfaceVersions As Integer()

        ''' <summary>
        ''' The Alpaca device's configured name
        ''' </summary>
        ''' <returns></returns>
        <DispId(6)> Property ServerName As String

        ''' <summary>
        ''' The device manufacturer's name
        ''' </summary>
        ''' <returns></returns>
        <DispId(7)> Property Manufacturer As String

        ''' <summary>
        ''' The device's version as set by the manufacturer
        ''' </summary>
        ''' <returns></returns>
        <DispId(8)> Property ManufacturerVersion As String

        ''' <summary>
        ''' The Alpaca device's configured location
        ''' </summary>
        ''' <returns></returns>
        <DispId(9)> Property Location As String

    End Interface

    ''' <summary>
    ''' Methods only visible to .NET clients
    ''' </summary>
    <ComVisible(False)>
    Public Interface IAlpacaDeviceExtra
        ''' <summary>
        ''' Array of ASCOM devices available on this Alpaca device
        ''' </summary>
        Property ConfiguredDevices As List(Of ConfiguredDevice)

    End Interface

    ''' <summary>
    ''' Methods visible to both COM and .NET clients
    ''' </summary>
    <Guid("4BF7844B-26BB-41DE-A500-26C65922F290"), ComVisible(True)>
    Public Interface IAscomDevice
        ''' <summary>
        ''' The ASCOM device's name
        ''' </summary>
        <DispId(1)> Property AscomDeviceName As String

        ''' <summary>
        ''' The ASCOM device's device type
        ''' </summary>
        <DispId(2)> Property AscomDeviceType As String

        ''' <summary>
        ''' The device's Alpaca API device number
        ''' </summary>
        <DispId(3)> Property AlpacaDeviceNumber As Integer

        ''' <summary>
        ''' ASCOM device unique ID
        ''' </summary>
        <DispId(4)> Property UniqueId As String

        ''' <summary>
        ''' The ASCOM device's DNS host name, if available, otherwise its IP address. IPv6 addresses will be in canonical form.
        ''' </summary>
        <DispId(5)> Property HostName As String

        ''' <summary>
        ''' The ASCOM device's IP address. IPv6 addresses will be in canonical form.
        ''' </summary>
        <DispId(6)> Property IpAddress As String

        ''' <summary>
        ''' SUpported Alpaca interface version
        ''' </summary>
        <DispId(7)> Property InterfaceVersion As Integer

        ''' <summary>
        ''' Alpaca device status message
        ''' </summary>
        <DispId(8)> Property StatusMessage As String

    End Interface

    ''' <summary>
    ''' Methods only visible to .NET clients
    ''' </summary>
    <ComVisible(False)>
    Friend Interface IAscomDeviceExtra
        Property IPEndPoint As IPEndPoint
    End Interface

    ''' <summary>
    ''' Methods visible to both COM and .NET clients
    ''' </summary>
    <Guid("696037F0-9138-4701-AA6C-CE6DB4091F6C"), ComVisible(True)>
    Public Interface IConfiguredDevice
        ''' <summary>
        ''' ASCOM device name
        ''' </summary>
        <DispId(1)> Property DeviceName As String

        ''' <summary>
        ''' ASCOM device type
        ''' </summary>
        <DispId(2)> Property DeviceType As String

        ''' <summary>
        ''' Device number used to access the device through the Alpaca API
        ''' </summary>
        <DispId(3)> Property DeviceNumber As Integer

        ''' <summary>
        ''' ASCOM device unique ID
        ''' </summary>
        <DispId(4)> Property UniqueID As String
    End Interface

    ''' <summary>
    ''' Methods visible to both COM and .NET clients
    ''' </summary>
    <Guid("EF7EA6E1-1074-4C07-BC42-079E1F486C2B"), ComVisible(True)>
    Public Interface IAlpacaDiscovery
        <DispId(1)> Property DiscoveryComplete As Boolean

        ''' <summary>
        ''' Returns an ArrayList of discovered Alpaca devices for use by COM clients
        ''' </summary>
        ''' <returns>ArrayList of <see cref="AlpacaDevice"/>classes</returns>
        ''' <remarks>This method is for use by COM clients because it is not possible to pass a generic list as used in <see cref="IAlpacaDiscoveryExtra.GetAlpacaDevices"/> through a COM interface. 
        ''' .NET clients should use <see cref="IAlpacaDiscoveryExtra.GetAlpacaDevices()"/> instead of this method.</remarks>
        <DispId(2)> Function GetAlpacaDevicesAsArrayList() As ArrayList

        ''' <summary>
        ''' Returns an ArrayList of discovered ASCOM devices, of the specified device type, for use by COM clients
        ''' </summary>
        ''' <param name="deviceType">The device type for which to search e.g. Telescope, Focuser. An empty string will return devices of all types.</param>
        ''' <returns>ArrayList of <see cref="AscomDevice"/>classes</returns>
        ''' <remarks>
        ''' <para>
        ''' This method is for use by COM clients because it is not possible to return a generic list, as used in <see cref="IAlpacaDiscoveryExtra.GetAscomDevices(String)"/>, through a COM interface. 
        ''' .NET clients should use <see cref="IAlpacaDiscoveryExtra.GetAscomDevices(String)"/> instead of this method.
        ''' </para>
        ''' <para>
        ''' This method will return every discovered device, regardless of device type, if the supplied "deviceType" parameter is an empty string.
        ''' </para>
        ''' </remarks>
        <DispId(3)> Function GetAscomDevicesAsArrayList(ByVal deviceType As String) As ArrayList

        ''' <summary>
        ''' Start an Alpaca device discovery based on the supplied parameters
        ''' </summary>
        ''' <param name="numberOfPolls">Number of polls to send in the range 1 to 5</param>
        ''' <param name="pollInterval">Interval between each poll in the range 10 to 5000 milliseconds</param>
        ''' <param name="discoveryPort">Discovery port on which to send the broadcast (normally 32227) in the range 1025 to 65535</param>
        ''' <param name="discoveryDuration">Length of time (seconds) to wait for devices to respond</param>
        ''' <param name="resolveDnsName">Attempt to resolve host IP addresses to DNS names</param>
        ''' <param name="useIpV4">Search for Alpaca devices that use IPv4 addresses. (One or both of useIpV4 and useIpV6 must be True.)</param>
        ''' <param name="useIpV6">Search for Alpaca devices that use IPv6 addresses. (One or both of useIpV4 and useIpV6 must be True.)</param>
        <DispId(4)> Sub StartDiscovery(ByVal numberOfPolls As Integer, ByVal pollInterval As Integer, ByVal discoveryPort As Integer, ByVal discoveryDuration As Double, ByVal resolveDnsName As Boolean, ByVal useIpV4 As Boolean, ByVal useIpV6 As Boolean)
    End Interface

    ''' <summary>
    ''' Methods only visible to .NET clients
    ''' </summary>
    <ComVisible(False)>
    Friend Interface IAlpacaDiscoveryExtra
        ''' <summary>
        ''' Returns a generic List of discovered Alpaca devices.
        ''' </summary>
        ''' <returns>List of <see cref="AlpacaDevice"/>classes</returns>
        ''' <remarks>This method is only available to .NET clients because COM cannot handle generic types. COM clients should use <see cref="IAlpacaDiscovery.GetAlpacaDevicesAsArrayList()"/>.</remarks>
        Function GetAlpacaDevices() As List(Of ASCOM.Utilities.AlpacaDevice)

        ''' <summary>
        ''' Returns a generic list of discovered ASCOM devices of the specified device type.
        ''' </summary>
        ''' <param name="deviceType">The device type for which to search e.g. Telescope, Focuser. An empty string will return devices of all types.</param>
        ''' <returns>List of AscomDevice classes</returns>
        ''' <remarks>
        ''' <para>
        ''' This method is only available to .NET clients because COM cannot handle generic types. COM clients should use <see cref="IAlpacaDiscovery.GetAscomDevicesAsArrayList(String)"/>.
        ''' </para>
        ''' <para>
        ''' This method will return every discovered device, regardless of device type, if the supplied "deviceType" parameter is an empty string.
        ''' </para>
        ''' </remarks>
        Function GetAscomDevices(ByVal deviceType As String) As List(Of ASCOM.Utilities.AscomDevice)

        ''' <summary>
        ''' Raised every time information about discovered devices is updated
        ''' </summary>
        ''' <remarks>This event is only available to .NET clients, there is no equivalent for COM clients.</remarks>
        Event AlpacaDevicesUpdated As EventHandler

        ''' <summary>
        ''' Raised when the discovery is complete
        ''' </summary>
        ''' <remarks>This event is only available to .NET clients. COM clients should poll the <see cref="IAlpacaDiscovery.DiscoveryComplete"/> property periodically to determine when discovery is complete.</remarks>
        Event DiscoveryCompleted As EventHandler

    End Interface

    ''' <summary>
    ''' Interface for KeyValuePair class
    ''' </summary>
    ''' <remarks>This is a return type only used by a small number of the Profile.XXXCOM commands. Including
    ''' <see cref="IProfile.RegisteredDevices">IProfile.RegisteredDevices</see>, 
    ''' <see cref="IProfile.SubKeys">IProfile.SubKeys</see> and 
    ''' <see cref="IProfile.Values">IProfile.Values</see>.</remarks>
    <Guid("CA653783-E47D-4e9d-9759-3B91BE0F4340"), ComVisible(True)>
    Public Interface IKeyValuePair
        ''' <summary>
        ''' Key member of a key value pair
        ''' </summary>
        ''' <value>Key</value>
        ''' <returns>Ky as string</returns>
        ''' <remarks></remarks>
        <DispId(1)>
        Property Key() As String
        ''' <summary>
        ''' Value memeber of a key value pair
        ''' </summary>
        ''' <value>Value</value>
        ''' <returns>Value as string</returns>
        ''' <remarks></remarks>
        <DispId(0)>
        Property Value() As String
    End Interface

    ''' <summary>
    ''' Interface to the TraceLogger component
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("1C7ABC95-8B63-475e-B5DB-D0CE7ADC436B"),
    ComVisible(True)>
    Public Interface ITraceLogger
        ''' <summary>
        ''' Writes the time and identifier to the log, leaving the line ready for further content through LogContinue and LogFinish
        ''' </summary>
        ''' <param name="Identifier">Identifies the meaning of the the message e.g. name of modeule or method logging the message.</param>
        ''' <param name="Message">Message to log</param>
        ''' <remarks><para>Use this to start a log line where you want to write further information on the line at a later time.</para>
        ''' <para>E.g. You might want to use this to record that an action has started and then append the word OK if all went well.
        '''  You would then end up with just one line to record the whole transaction even though you didn't know that it would be 
        ''' successful when you started. If you just used LogMsg you would have ended up with two log lines, one showing 
        ''' the start of the transaction and the next the outcome.</para>
        ''' <para>Will create a LOGISSUE message in the log if called before a line started by LogStart has been closed with LogFinish. 
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' </remarks>
        <DispId(1)> Sub LogStart(ByVal Identifier As String, ByVal Message As String)

        ''' <summary>
        ''' Appends further message to a line started by LogStart, appends a hex translation of the message to the line, does not terminate the line.
        ''' </summary>
        ''' <param name="Message">The additional message to appear in the line</param>
        ''' <param name="HexDump">True to append a hex translation of the message at the end of the message</param>
        ''' <remarks>
        ''' <para>This can be called multiple times to build up a complex log line if required.</para>
        ''' <para>Will create a LOGISSUE message in the log if called before a line has been started with LogStart. 
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' </remarks>
        <DispId(2)> Overloads Sub LogContinue(ByVal Message As String, ByVal HexDump As Boolean) ' Append a full hex dump of the supplied string without a new line

        ''' <summary>
        ''' Closes a line started by LogStart with option to append a translation of the supplied message into HEX
        ''' </summary>
        ''' <param name="Message">The final message to appear in the line</param>
        ''' <param name="HexDump">True to append a hex translation of the message at the end of the message</param>
        ''' <remarks></remarks>
        <DispId(3)> Overloads Sub LogFinish(ByVal Message As String, ByVal HexDump As Boolean) ' Append a full hex dump of the supplied string with a new line

        ''' <summary>
        ''' Closes a line started by LogStart with the supplied message and a hex translation of the message
        ''' </summary>
        ''' <param name="Identifier">Identifies the meaning of the the message e.g. name of modeule or method logging the message.</param>
        ''' <param name="Message">The final message to terminate the line</param>
        ''' <param name="HexDump">True to append a hex translation of the message at the end of the message</param>
        ''' <remarks>
        ''' <para>Will create a LOGISSUE message in the log if called before a line has been started with LogStart.  
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' </remarks>
        <DispId(4)> Overloads Sub LogMessage(ByVal Identifier As String, ByVal Message As String, ByVal HexDump As Boolean) ' Append a full hex dump of the supplied string with a new line

        ''' <summary>
        ''' Enables or disables logging to the file.
        ''' </summary>
        ''' <value>True to enable logging</value>
        ''' <returns>Boolean, current logging status (enabled/disabled).</returns>
        ''' <remarks>If this property is false then calls to LogMsg, LogStart, LogContinue and LogFinish do nothing. If True, 
        ''' supplied messages are written to the log file.</remarks>
        <DispId(5)> Property Enabled() As Boolean

        ''' <summary>
        ''' Logs an issue, closing any open line and opening a continuation line if necessary after the 
        ''' issue message.
        ''' </summary>
        ''' <param name="Identifier">Identifies the meaning of the the message e.g. name of modeule or method logging the message.</param>
        ''' <param name="Message">Message to log</param>
        ''' <remarks>Use this for reporting issues that you don't want to appear on a line already opened 
        ''' with StartLine</remarks>
        <DispId(6)> Sub LogIssue(ByVal Identifier As String, ByVal Message As String)

        ''' <summary>
        ''' Sets the log filename and type if the constructor is called without parameters
        ''' </summary>
        ''' <param name="LogFileName">Fully qualified trace file name or null string to use automatic file naming (recommended)</param>
        ''' <param name="LogFileType">String identifying the type of log e,g, Focuser, LX200, GEMINI, MoonLite, G11</param>
        ''' <remarks>The LogFileType is used in the file name to allow you to quickly identify which of several logs contains the 
        ''' information of interest.
        ''' <para><b>Note </b>This command is only required if the tracelogger constructor is called with no
        ''' parameters. It is provided for use in COM clients that can not call constructors with parameters.
        ''' If you are writing a COM client then create the trace logger as:</para>
        ''' <code>
        ''' TL = New TraceLogger()
        ''' TL.SetLogFile("","TraceName")
        ''' </code>
        ''' <para>If you are writing a .NET client then you can achieve the same end in one call:</para>
        ''' <code>
        ''' TL = New TraceLogger("",TraceName")
        ''' </code>
        ''' </remarks>
        <DispId(7)> Sub SetLogFile(ByVal LogFileName As String, ByVal LogFileType As String)

        ''' <summary>
        ''' Insert a blank line into the log file
        ''' </summary>
        ''' <remarks></remarks>
        <DispId(8)> Sub BlankLine()

        ''' <summary>
        ''' Return the full filename of the log file being created
        ''' </summary>
        ''' <value>Full filename of the log file</value>
        ''' <returns>String filename</returns>
        ''' <remarks>This call will return an empty string until the first line has been written to the log file
        ''' as the file is not created until required.</remarks>
        <DispId(9)> ReadOnly Property LogFileName() As String

        ''' <summary>
        ''' Displays a message respecting carriage return and linefeed characters
        ''' </summary>
        ''' <param name="Identifier">Identifies the meaning of the the message e.g. name of modeule or method logging the message.</param>
        ''' <param name="Message">The final message to terminate the line</param>
        ''' <remarks>
        ''' <para>Will create a LOGISSUE message in the log if called before a line has been started with LogStart.  
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' </remarks>
        <DispId(10)> Sub LogMessageCrLf(ByVal Identifier As String, ByVal Message As String) ' Append a full hex dump of the supplied string with a new line

        ''' <summary>
        ''' Set or return the path to a directory in which the log file will be created
        ''' </summary>
        ''' <value>Path to the log directory</value>
        ''' <returns>String path</returns>
        ''' <remarks>Introduced with Platform 6.4.<para>If set, this path will be used instead of the the user's Documents directory default path. This must be Set before the first message Is logged.</para></remarks>
        <DispId(11)> Property LogFilePath() As String

        ''' <summary>
        ''' Set or return the width of the identifier field in the log message
        ''' </summary>
        ''' <value>Width of the identifier field</value>
        ''' <returns>Integer width</returns>
        ''' <remarks>Introduced with Platform 6.4.<para>If set, this width will be used instead of the default identifier field width.</para></remarks>
        <DispId(12)> Property IdentifierWidth() As Integer

    End Interface ' Interface to Utilities.TraceLogger

    ''' <summary>
    ''' Addiitonal methods that are only visible to .NET clients and not to COM clients
    ''' </summary>
    ''' <remarks></remarks>
    <ComVisible(False)> Public Interface ITraceLoggerExtra
        ''' <summary>
        ''' Appends further message to a line started by LogStart, does not terminate the line.
        ''' </summary>
        ''' <param name="Message">The additional message to appear in the line</param>
        ''' <remarks>
        ''' <para>This can be called multiple times to build up a complex log line if required.</para>
        ''' <para>Will create a LOGISSUE message in the log if called before a line has been started with LogStart. 
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "LogContinue(ByVal Message As String, ByVal HexDump As Boolean)"
        ''' with HexDump set False to achieve this effect.</para>
        ''' </remarks>
        Overloads Sub LogContinue(ByVal Message As String)

        ''' <summary>
        ''' Closes a line started by LogStart with the supplied message
        ''' </summary>
        ''' <param name="Message">The final message to terminate the line</param>
        ''' <remarks>
        ''' <para>Can only be called once for each line started by LogStart.</para>
        ''' <para>Will create a LOGISSUE message in the log if called before a line has been started with LogStart.  
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "LogFinish(ByVal Message As String, ByVal HexDump As Boolean)"
        ''' with HexDump set False to achieve this effect.</para>
        ''' </remarks>
        Overloads Sub LogFinish(ByVal Message As String)

        ''' <summary>
        ''' Logs a complete message in one call
        ''' </summary>
        ''' <param name="Identifier">Identifies the meaning of the the message e.g. name of modeule or method logging the message.</param>
        ''' <param name="Message">Message to log</param>
        ''' <remarks>
        ''' <para>Use this for straightforward logging requrements. Writes all information in one command.</para>
        ''' <para>Will create a LOGISSUE message in the log if called before a line started by LogStart has been closed with LogFinish. 
        ''' Posible reasons for this are exceptions causing the normal flow of code to be bypassed or logic errors.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "LogMessage(ByVal Identifier As String, ByVal Message As String, ByVal HexDump As Boolean)"
        ''' with HexDump set False to achieve this effect.</para>
        ''' </remarks>
        Overloads Sub LogMessage(ByVal Identifier As String, ByVal Message As String)
    End Interface

    ''' <summary>
    ''' Interface to the .NET Chooser component
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("D398FD76-F4B8-48a2-9CA3-2EF0DD8B98E1"), ComVisible(True)>
    Public Interface IChooser
        ''' <summary>
        ''' The type of device for which the Chooser will select a driver. (String, default = "Telescope")
        ''' </summary>
        ''' <value>The type of device for which the Chooser will select a driver. (String, default = "Telescope") 
        '''</value>
        ''' <returns>The device type that has been set</returns>
        ''' <remarks>This property changes the "personality" of the Chooser, allowing it to be used to select a driver for any arbitrary 
        ''' ASCOM device type. The default value for this is "Telescope", but it could be "Focuser", "Camera", etc. 
        ''' <para>This property is independent of the Profile object's DeviceType property. Setting Chooser's DeviceType 
        ''' property doesn't set the DeviceType property in Profile, you must set that also when needed.</para>
        '''</remarks>
        <DispId(1)> Property DeviceType() As String

        ''' <summary>
        ''' Select ASCOM driver to use including pre-selecting one in the dropdown list
        ''' </summary>
        ''' <param name="DriverProgID">Driver to preselect in the chooser dialogue</param>
        ''' <returns>Driver ID of chosen driver</returns>
        ''' <remarks>The supplied driver will be pre-selected in the Chooser's list when the chooser window is first opened.
        ''' </remarks>
        <DispId(2)> Overloads Function Choose(ByVal DriverProgID As String) As String
    End Interface 'Interface to Utilities.Chooser

    ''' <summary>
    ''' Addiitonal methods that are only visible to .NET clients and not to COM clients
    ''' </summary>
    ''' <remarks></remarks>
    <ComVisible(False)> Public Interface IChooserExtra
        ''' <summary>
        ''' Select ASCOM driver to use without pre-selecting in the dropdown list
        ''' </summary>
        ''' <returns>Driver ID of chosen driver</returns>
        ''' <remarks>No driver will be pre-selected in the Chooser's list when the chooser window is first opened. 
        ''' <para>This overload is not available through COM, please use "Choose(ByVal DriverProgID As String)"
        ''' with an empty string parameter to achieve this effect.</para>
        ''' </remarks>
        Overloads Function Choose() As String
    End Interface

    ''' <summary>
    ''' Interface to the .NET Util component
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("DF41946E-EE14-40f7-AA66-DD8A92E36EF2"),
    ComVisible(True)>
    Public Interface IUtil
        'Interface for the new larger Util class including overloads to replace optional parameters
        ''' <summary>
        ''' Pauses for a given interval in milliseconds.
        ''' </summary>
        ''' <param name="Milliseconds">The number of milliseconds to wait</param>
        ''' <remarks>Repeatedly puts the calling Win32 process to sleep, totally freezing it, for 10 milliseconds, 
        ''' then pumps events so the script or program calling it will receive its normal flow of events, until the 
        ''' pause interval elapses. If the pause interval is 20 milliseconds or less, the sleep interval is reduced 
        ''' to 0, causing the calling Win32 process to give up control to the kernel scheduler and then immediately 
        ''' become eligible for scheduling. </remarks>
        <DispId(1)> Sub WaitForMilliseconds(ByVal Milliseconds As Integer)

        ''' <summary>
        ''' Convert sexagesimal degrees to binary double-precision degrees
        ''' </summary>
        ''' <param name="DMS">The sexagesimal input string (degrees)</param>
        ''' <returns>The double-precision binary value (degrees) represented by the sexagesimal input</returns>
        ''' <remarks><para>The sexagesimal to real conversion methods such as this one are flexible enough to convert just 
        ''' about anything that resembles sexagesimal. Thee way they operate is to first separate the input string 
        ''' into numeric "tokens", strings consisting only of the numerals 0-9, plus and minus, and period. All other 
        ''' characters are considered delimiters. Once the input string is parsed into tokens they are converted to 
        ''' numerics. </para>
        ''' <para>If there are more than three numeric tokens, only the first three are considered, the remainder 
        ''' are ignored. Left to right positionally, the tokens are assumed to represent units (degrees or hours), 
        ''' minutes, and seconds. If only two tokens are present, they are assumed to be units and minutes, and if 
        ''' only one token is present, it is assumed to be units. Any token can have a fractionsl part. Of course it 
        ''' would not be normal (for example) for both the minutes and seconds parts to have fractional parts, but it 
        ''' would be legal. So 00:30.5:30 would convert to 1.0 unit. </para>
        ''' <para>Note that plain units, for example 23.128734523 are acceptable to the method. </para>
        ''' </remarks>
        <DispId(2)> Function DMSToDegrees(ByVal DMS As String) As Double

        ''' <summary>
        ''' Convert sexagesimal hours to binary double-precision hours
        ''' </summary>
        ''' <param name="HMS">The sexagesimal input string (hours)</param>
        ''' <returns>The double-precision binary value (hours) represented by the sexagesimal input </returns>
        ''' <remarks>
        ''' <para>The sexagesimal to real conversion methods such as this one are flexible enough to convert just about 
        ''' anything that resembles sexagesimal. Thee way they operate is to first separate the input string into 
        ''' numeric "tokens", strings consisting only of the numerals 0-9, plus and minus, and period. All other 
        ''' characters are considered delimiters. Once the input string is parsed into tokens they are converted to 
        ''' numerics. </para>
        ''' 
        ''' <para>If there are more than three numeric tokens, only the first three are considered, the remainder 
        ''' are ignored. Left to right positionally, the tokens are assumed to represent units (degrees or hours), 
        ''' minutes, and seconds. If only two tokens are present, they are assumed to be units and minutes, and if 
        ''' only one token is present, it is assumed to be units. Any token can have a fractionsl part. </para>
        ''' 
        ''' <para>Of course it would not be normal (for example) for both the minutes and seconds parts to have 
        ''' fractional parts, but it would be legal. So 00:30.5:30 would convert to 1.0 unit. Note that plain units, 
        ''' for example 23.128734523 are acceptable to the method. </para>
        ''' </remarks>
        <DispId(3)> Function HMSToHours(ByVal HMS As String) As Double

        ''' <summary>
        ''' Convert sexagesimal hours to binary double-precision hours
        ''' </summary>
        ''' <param name="HMS">The sexagesimal input string (hours)</param>
        ''' <returns>The double-precision binary value (hours) represented by the sexagesimal input</returns>
        ''' <remarks>
        ''' <para>The sexagesimal to real conversion methods such as this one are flexible enough to convert just about 
        ''' anything that resembles sexagesimal. Thee way they operate is to first separate the input string into 
        ''' numeric "tokens", strings consisting only of the numerals 0-9, plus and minus, and period. All other 
        ''' characters are considered delimiters. Once the input string is parsed into tokens they are converted to 
        ''' numerics. </para>
        ''' 
        ''' <para>If there are more than three numeric tokens, only the first three are considered, the remainder 
        ''' are ignored. Left to right positionally, the tokens are assumed to represent units (degrees or hours), 
        ''' minutes, and seconds. If only two tokens are present, they are assumed to be units and minutes, and if 
        ''' only one token is present, it is assumed to be units. Any token can have a fractionsl part. </para>
        ''' 
        ''' <para>Of course it would not be normal (for example) for both the minutes and seconds parts to have 
        ''' fractional parts, but it would be legal. So 00:30.5:30 would convert to 1.0 unit. Note that plain units, 
        ''' for example 23.128734523 are acceptable to the method. </para>
        ''' </remarks>
        <DispId(4)> Function HMSToDegrees(ByVal HMS As String) As Double

        ''' <summary>
        '''  Convert degrees to sexagesimal degrees, minutes and seconds with specified second decimal places
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees and minutes </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part </param>
        ''' <param name="SecDelim">The delimiter string to append to the seconds part</param>
        ''' <param name="SecDecimalDigits">The number of digits after the decimal point on the seconds part </param>
        ''' <returns>Sexagesimal representation of degrees input value, degrees, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal SecDelim As String)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        <DispId(5)> Overloads Function DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer) As String

        ''' <summary>
        ''' Convert hours to sexagesimal hours, minutes, and seconds with specified number of second decimal places
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes </param>
        ''' <param name="MinDelim">The delimiter string separating minutes and seconds </param>
        ''' <param name="SecDelim">The delimiter string to append to the seconds part </param>
        ''' <param name="SecDecimalDigits">The number of digits after the decimal point on the seconds part </param>
        ''' <returns>Sexagesimal representation of hours input value, hours, minutes and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' </remarks>
        <DispId(6)> Overloads Function HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer) As String

        ''' <summary>
        ''' Convert degrees to sexagesimal degrees and minutes with the specified number of minute decimal places
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes </param>
        ''' <param name="MinDecimalDigits">The number of digits after the decimal point on the minutes part </param>
        ''' <returns>Sexagesimal representation of degrees input value, as degrees and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' </remarks>
        <DispId(7)> Overloads Function DegreesToDM(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer) As String

        ''' <summary>
        ''' Convert hours to sexagesimal hours and minutes with supplied number of minute decimal places
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part </param>
        ''' <param name="MinDecimalDigits">The number of digits after the decimal point on the minutes part </param>
        ''' <returns>Sexagesimal representation of hours input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' </remarks>
        <DispId(8)> Overloads Function HoursToHM(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer) As String

        ''' <summary>
        ''' Convert degrees to sexagesimal hours, minutes, and seconds with the specified number of second decimal places
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <param name="MinDelim">The delimiter string separating minutes and seconds</param>
        ''' <param name="SecDelim">The delimiter string to append to the seconds part </param>
        ''' <param name="SecDecimalDigits">The number of digits after the decimal point on the seconds part </param>
        ''' <returns>Sexagesimal representation of degrees input value, as hours, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters. </para>
        ''' </remarks>
        <DispId(9)> Overloads Function DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer) As String

        ''' <summary>
        ''' Convert degrees to sexagesimal hours and minutes with supplied number of minute decimal places
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part</param>
        ''' <param name="MinDecimalDigits">The number of minutes decimal places</param>
        ''' <returns>Sexagesimal representation of degrees input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters</para>
        ''' </remarks>
        <DispId(10)> Overloads Function DegreesToHM(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer) As String

        ''' <summary>
        ''' Current Platform version in m.n form
        ''' </summary>
        ''' <returns>Current Platform version in m.n form</returns>
        ''' <remarks></remarks>
        <DispId(11)> ReadOnly Property PlatformVersion() As String

        ''' <summary>
        ''' Change the serial trace file (default C:\SerialTrace.txt)
        ''' </summary>
        ''' <value>Serial trace file name including fully qualified path e.g. C:\SerialTrace.txt</value>
        ''' <returns>Serial trace file name </returns>
        ''' <remarks>Change this before setting the SerialTrace property to True. </remarks>
        <DispId(12)> Property SerialTraceFile() As String

        ''' <summary>
        ''' Enable/disable serial I/O tracing
        ''' </summary>
        ''' <value>Boolean - Enable/disable serial I/O tracing</value>
        ''' <returns>Enabled - disabled state of serial tracing</returns>
        ''' <remarks>If you want to change the serial trace file path, change the SerialTraceFile property before setting this to True. 
        ''' After setting this to True, serial trace info will be written to the last-set serial trace file. </remarks>
        <DispId(13)> Property SerialTrace() As Boolean

        ''' <summary>
        ''' The name of the computer's time zone
        ''' </summary>
        ''' <returns>The name of the computer's time zone</returns>
        ''' <remarks>This will be in the local language of the operating system, and will reflect any daylight/summer time that may be in 
        ''' effect. </remarks>
        <DispId(14)> ReadOnly Property TimeZoneName() As String

        ''' <summary>
        ''' UTC offset (hours) for the computer's clock
        ''' </summary>
        ''' <returns>UTC offset (hours) for the computer's clock</returns>
        ''' <remarks>The offset is in hours, such that UTC = local + offset. The offset includes any daylight/summer time that may be 
        ''' in effect.</remarks>
        <DispId(15)> ReadOnly Property TimeZoneOffset() As Double

        ''' <summary>
        ''' The current UTC Date
        ''' </summary>
        ''' <returns>The current UTC Date</returns>
        ''' <remarks></remarks>
        <DispId(16)> ReadOnly Property UTCDate() As Date

        ''' <summary>
        ''' Current Julian date
        ''' </summary>
        ''' <returns>Current Julian date</returns>
        ''' <remarks>This is quantised to the second in the COM component but to a small decimal fraction in the .NET component</remarks>
        <DispId(17)> ReadOnly Property JulianDate() As Double

        ''' <summary>
        ''' Convert local-time Date to Julian date
        ''' </summary>
        ''' <param name="LocalDate">Date in local-time</param>
        ''' <returns>Julian date</returns>
        ''' <remarks>Julian dates are always in UTC </remarks>
        <DispId(18)> Function DateLocalToJulian(ByVal LocalDate As Date) As Double

        ''' <summary>
        ''' Convert Julian date to local-time Date
        ''' </summary>
        ''' <param name="JD">Julian date to convert</param>
        ''' <returns>Date in local-time for the given Julian date</returns>
        ''' <remarks>Julian dates are always in UTC</remarks>
        <DispId(19)> Function DateJulianToLocal(ByVal JD As Double) As Date

        ''' <summary>
        ''' Convert UTC Date to Julian date
        ''' </summary>
        ''' <param name="UTCDate">UTC date to convert</param>
        ''' <returns>Julian date</returns>
        ''' <remarks>Julian dates are always in UTC </remarks>
        <DispId(20)> Function DateUTCToJulian(ByVal UTCDate As Date) As Double

        ''' <summary>
        ''' Convert Julian date to UTC Date
        ''' </summary>
        ''' <param name="JD">Julian date</param>
        ''' <returns>Date in UTC for the given Julian date</returns>
        ''' <remarks>Julian dates are always in UTC </remarks>
        <DispId(21)> Function DateJulianToUTC(ByVal JD As Double) As Date

        ''' <summary>
        ''' Convert UTC Date to local-time Date
        ''' </summary>
        ''' <param name="UTCDate">Date in UTC</param>
        ''' <returns>Date in local-time</returns>
        ''' <remarks></remarks>
        <DispId(22)> Function DateUTCToLocal(ByVal UTCDate As Date) As Date

        ''' <summary>
        ''' Convert local-time Date to UTC Date
        ''' </summary>
        ''' <param name="LocalDate">Date in local-time</param>
        ''' <returns> Date in UTC</returns>
        ''' <remarks></remarks>
        <DispId(23)> Function DateLocalToUTC(ByVal LocalDate As Date) As Date

        ''' <summary>
        ''' Tests whether the current platform version is at least equal to the supplied major and minor 
        ''' version numbers, returns false if this is not the case
        ''' </summary>
        ''' <param name="RequiredMajorVersion">The required major version number</param>
        ''' <param name="RequiredMinorVersion">The required minor version number</param>
        ''' <returns>True if the current platform version equals or exceeds the major and minor values provided</returns>
        ''' <remarks>This function provides a simple way to test for a minimum platform level.
        ''' If for example, your application requires at least platform version 5.5 then you can use 
        ''' code such as this to make a test and display information as appropriate.
        ''' <code>Const Int requiredMajorVersion = 5;
        ''' Const Int requiredMinorVersion = 5; // Requires Platform version 5.5
        ''' Bool isOK = ASCOM.Utilities.IsMinimumRequiredVersion(requiredMajorVersion,
        ''' requiredMinorVersion);
        ''' If (isOK)
        ''' // Do the install (or whatever)
        ''' Else
        ''' // Abort, throw exception, print an error.
        ''' </code></remarks>
        <DispId(24)> Function IsMinimumRequiredVersion(ByVal RequiredMajorVersion As Integer, ByVal RequiredMinorVersion As Integer) As Boolean

        ''' <summary>
        ''' Converts a safearray of strings to a collection that can be used in scripting.
        ''' This is required to do things such as handling the array of names returned by the FilterWheel.Names property.
        ''' This string array won't work in scripting languages.
        ''' </summary>
        ''' <param name="stringArray">array of strings</param>
        ''' <returns>Collection of strings</returns>
        ''' <remarks></remarks>
        <DispId(25)> Function ToStringCollection(ByVal stringArray As String()) As ArrayList

        ''' <summary>
        ''' Converts a safearray of integers to a collection that can be used in scripting languages.
        ''' This is required to handle properties that are returned as safearrays of integers, for  example FilterWheel.FocusOffsets
        ''' SafeArrays don't work in scripting languages.
        ''' </summary>
        ''' <param name="integerArray">array of integers</param>
        ''' <returns>Collection of Integers</returns>
        ''' <remarks></remarks>
        <DispId(26)> Function ToIntegerCollection(ByVal integerArray As Integer()) As ArrayList

        ''' <summary>
        ''' Convert an array of .NET built-in types to an equivalent Variant arrray (array of .NET Objects)
        ''' </summary>
        ''' <param name="SuppliedObject">The array to convert to variant types</param>
        ''' <returns>A Variant array</returns>
        ''' <exception cref="InvalidValueException">If the supplied array contains elements of an unsuported Type.</exception>
        ''' <exception cref="InvalidValueException">If the array rank is outside the range 1 to 5.</exception>
        ''' <exception cref="InvalidValueException">If the supplied object is not an array.</exception>
        ''' <remarks>This function will primarily be of use to Scripting Language programmers who need to convert Camera and Video ImageArrays from their native types to Variant types. If this is not done, 
        ''' the scripting language will throw a type mismatch exception when it receives, for example, Int32 element types instead of the expected Variant types.
        ''' <para>A VBScript Camera usage example is: Image = UTIL.ArrayToVariantArray(CAMERA.ImageArray) This example assumes that the camera and utilities objects have already been created with CreateObject statements.</para>
        ''' <para>The supported .NET types are:
        ''' <list type="bullet">
        ''' <item><description>Int16</description></item>
        ''' <item><description>Int32</description></item>
        ''' <item><description>UInt16</description></item>
        ''' <item><description>UInt32</description></item>
        ''' <item><description>UInt64</description></item>
        ''' <item><description>Byte</description></item>
        ''' <item><description>SByte</description></item>
        ''' <item><description>Single</description></item>
        ''' <item><description>Double</description></item>
        ''' <item><description>Boolean</description></item>
        ''' <item><description>DateTime</description></item>
        ''' <item><description>String</description></item>
        ''' </list>
        ''' </para>
        ''' <para>The function supports arrays with 1 to 5 dimensions (Rank = 1 to 5). If the supplied array already contains elements of Variant type, it is returned as-is without any processing.</para></remarks>
        <DispId(27)> Function ArrayToVariantArray(ByVal SuppliedObject As Object) As <MarshalAs(UnmanagedType.SafeArray, SafeArraySubType:=VarEnum.VT_VARIANT)> Object

        ''' <summary>
        ''' Platform major version number
        ''' </summary>
        ''' <value>Platform major version number</value>
        ''' <returns>Integer version number</returns>
        ''' <remarks></remarks>
        <DispId(28)> ReadOnly Property MajorVersion As Integer

        ''' <summary>
        ''' Platform minor version number
        ''' </summary>
        ''' <value>Platform minor version number</value>
        ''' <returns>Integer version number</returns>
        ''' <remarks></remarks>
        <DispId(29)> ReadOnly Property MinorVersion As Integer

        ''' <summary>
        ''' Platform service pack number
        ''' </summary>
        ''' <value>Platform service pack number</value>
        ''' <returns>Integer service pack number</returns>
        ''' <remarks></remarks>
        <DispId(30)> ReadOnly Property ServicePack As Integer

        ''' <summary>
        ''' Platform build number
        ''' </summary>
        ''' <value>Platform build number</value>
        ''' <returns>Integer build number</returns>
        ''' <remarks></remarks>
        <DispId(31)> ReadOnly Property BuildNumber As Integer

        ''' <summary>
        ''' Convert from one set of units to another
        ''' </summary>
        ''' <param name="InputValue">Value to convert</param>
        ''' <param name="FromUnits">Integer value from the Units enum indicating the value's current units</param>
        ''' <param name="ToUnits">Integer value from the Units enum indicating the units to which the input value should be converted</param>
        ''' <returns>Input value converted to the new specified units</returns>
        <DispId(32)> Function ConvertUnits(InputValue As Double, FromUnits As Units, ToUnits As Units) As Double

        ''' <summary>
        ''' Calculate the dew point given the ambient temperature and humidity
        ''' </summary>
        ''' <param name="Humidity">Humidity expressed in percent (0.0 .. 100.0)</param>
        ''' <param name="AmbientTemperature">Ambient temperature in degrees C</param>
        ''' <returns>Dew point in degrees C</returns>
        <DispId(33)> Function Humidity2DewPoint(Humidity As Double, AmbientTemperature As Double) As Double

        ''' <summary>
        ''' Calculate the humidity given the ambient temperature and dew point
        ''' </summary>
        ''' <param name="DewPoint">Dewpoint in degrees C</param>
        ''' <param name="AmbientTemperature">Ambient temperature in degrees C</param>
        ''' <returns>Humidity expressed in percent (0.0 .. 100.0)</returns>
        <DispId(34)> Function DewPoint2Humidity(DewPoint As Double, AmbientTemperature As Double) As Double

        ''' <summary>
        ''' Convert atmospheric pressure from one altitude above mean sea level to another
        ''' </summary>
        ''' <param name="Pressure">Measured pressure in hPa at the "From" altitude</param>
        ''' <param name="FromAltitudeAboveMeanSeaLevel">"Altitude at which the input pressure was measured</param>
        ''' <param name="ToAltitudeAboveMeanSeaLevel">Altitude to which the pressure is to be converted</param>
        ''' <returns>Pressure in hPa at the "To" altitude</returns>
        <DispId(35)> Function ConvertPressure(Pressure As Double, FromAltitudeAboveMeanSeaLevel As Double, ToAltitudeAboveMeanSeaLevel As Double) As Double

    End Interface 'Interface to Utilities.Util

    ''' <summary>
    ''' Addiitonal methods that are only visible to .NET clients and not to COM clients
    ''' </summary>
    ''' <remarks></remarks>
    <ComVisible(False)> Public Interface IUtilExtra
        ''' <summary>
        ''' Convert degrees to sexagesimal degrees, minutes and seconds with default delimiters DD° MM' SS" 
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <returns>Sexagesimal representation of degrees input value, degrees, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single 
        ''' characters.</para>
        ''' <para>This overload is not available through COM, please use "Choose(ByVal DriverProgID As String)"
        ''' with an empty string parameter to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDMS(ByVal Degrees As Double) As String
        ''' <summary>
        '''  Convert degrees to sexagesimal degrees, minutes and seconds with with default minute and second delimiters MM' SS" 
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees and minutes </param>
        ''' <returns>Sexagesimal representation of degrees input value, degrees, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single 
        ''' characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal SecDelim As String)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String) As String
        ''' <summary>
        '''  Convert degrees to sexagesimal degrees, minutes and seconds with default second delimiter SS" 
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees and minutes </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part </param>
        ''' <returns>Sexagesimal representation of degrees input value, degrees, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single 
        ''' characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal SecDelim As String)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String) As String
        ''' <summary>
        '''  Convert degrees to sexagesimal degrees, minutes and seconds
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees and minutes </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part </param>
        ''' <param name="SecDelim">The delimiter string to append to the seconds part</param>
        ''' <returns>Sexagesimal representation of degrees input value, degrees, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single 
        ''' characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal SecDelim As String)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDMS(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal SecDelim As String) As String

        ''' <summary>
        ''' Convert hours to sexagesimal hours, minutes, and seconds with default delimiters HH:MM:SS
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <returns>Sexagesimal representation of hours input value, hours, minutes and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHMS(ByVal Hours As Double) As String
        ''' <summary>
        ''' Convert hours to sexagesimal hours, minutes, and seconds with default minutes and seconds delimters MM:SS
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes </param>
        ''' <returns>Sexagesimal representation of hours input value, hours, minutes and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String) As String
        ''' <summary>
        ''' Convert hours to sexagesimal hours, minutes, and seconds with default second delimiter of null string
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes </param>
        ''' <param name="MinDelim">The delimiter string separating minutes and seconds </param>
        ''' <returns>Sexagesimal representation of hours input value, hours, minutes and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String) As String
        ''' <summary>
        ''' Convert hours to sexagesimal hours, minutes, and seconds
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes </param>
        ''' <param name="MinDelim">The delimiter string separating minutes and seconds </param>
        ''' <param name="SecDelim">The delimiter string to append to the seconds part </param>
        ''' <returns>Sexagesimal representation of hours input value, hours, minutes and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHMS(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String) As String

        ''' <summary>
        ''' Convert degrees to sexagesimal degrees and minutes with default delimiters DD° MM'
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <returns>Sexagesimal representation of degrees input value, as degrees and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDM(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDM(ByVal Degrees As Double) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal degrees and minutes with the default minutes delimeter MM'
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees </param>
        ''' <returns>Sexagesimal representation of degrees input value, as degrees and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDM(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDM(ByVal Degrees As Double, ByVal DegDelim As String) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal degrees and minutes
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="DegDelim">The delimiter string separating degrees </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes </param>
        ''' <returns>Sexagesimal representation of degrees input value, as degrees and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToDM(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToDM(ByVal Degrees As Double, ByVal DegDelim As String, ByVal MinDelim As String) As String

        ''' <summary>
        ''' Convert hours to sexagesimal hours and minutes with default delimiters HH:MM
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <returns>Sexagesimal representation of hours input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHM(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with an suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHM(ByVal Hours As Double) As String
        ''' <summary>
        ''' Convert hours to sexagesimal hours and minutes with default minutes delimiter MM (null string)
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <returns>Sexagesimal representation of hours input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHM(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with an suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHM(ByVal Hours As Double, ByVal HrsDelim As String) As String
        ''' <summary>
        ''' Convert hours to sexagesimal hours and minutes
        ''' </summary>
        ''' <param name="Hours">The hours value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part </param>
        ''' <returns>Sexagesimal representation of hours input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "HoursToHM(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with an suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function HoursToHM(ByVal Hours As Double, ByVal HrsDelim As String, ByVal MinDelim As String) As String

        ''' <summary>
        ''' Convert degrees to sexagesimal hours, minutes, and seconds with default delimters of HH:MM:SS
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <returns>Sexagesimal representation of degrees input value, as hours, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself.</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHMS(ByVal Degrees As Double) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal hours, minutes, and seconds with the default second and minute delimiters of MM:SS
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <returns>Sexagesimal representation of degrees input value, as hours, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters. </para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal hours, minutes, and seconds with the default second delimiter SS (null string)
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <param name="MinDelim">The delimiter string separating minutes and seconds</param>
        ''' <returns>Sexagesimal representation of degrees input value, as hours, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters. </para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal hours, minutes, and seconds
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes</param>
        ''' <param name="MinDelim">The delimiter string separating minutes and seconds</param>
        ''' <param name="SecDelim">The delimiter string to append to the seconds part </param>
        ''' <returns>Sexagesimal representation of degrees input value, as hours, minutes, and seconds</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters. </para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String, ByVal SecDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHMS(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal SecDelim As String) As String

        ''' <summary>
        ''' Convert degrees to sexagesimal hours and minutes with default delimiters HH:MM
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <returns>Sexagesimal representation of degrees input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHM(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHM(ByVal Degrees As Double) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal hours and minutes with default minute delimiter MM (null string)
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes </param>
        ''' <returns>Sexagesimal representation of degrees input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHM(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHM(ByVal Degrees As Double, ByVal HrsDelim As String) As String
        ''' <summary>
        ''' Convert degrees to sexagesimal hours and minutes
        ''' </summary>
        ''' <param name="Degrees">The degrees value to convert</param>
        ''' <param name="HrsDelim">The delimiter string separating hours and minutes </param>
        ''' <param name="MinDelim">The delimiter string to append to the minutes part </param>
        ''' <returns>Sexagesimal representation of degrees input value as hours and minutes</returns>
        ''' <remarks>
        ''' <para>If you need a leading plus sign, you must prepend it yourself. The delimiters are not restricted to single characters</para>
        ''' <para>This overload is not available through COM, please use 
        ''' "DegreesToHM(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String, ByVal MinDecimalDigits As Integer)"
        ''' with suitable parameters to achieve this effect.</para>
        ''' </remarks>
        Overloads Function DegreesToHM(ByVal Degrees As Double, ByVal HrsDelim As String, ByVal MinDelim As String) As String
    End Interface

    ''' <summary>
    ''' Interface to the .NET Timer component
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("23A8A279-FB8E-4b3c-8F2E-010AC0F98588"),
    ComVisible(True)>
    Public Interface ITimer
        'Interface for the Timer class

        ''' <summary>
        ''' The interval between Tick events when the timer is Enabled in milliseconds, (default = 1000)
        ''' </summary>
        ''' <value>The interval between Tick events when the timer is Enabled (milliseconds, default = 1000)</value>
        ''' <returns>The interval between Tick events when the timer is Enabled in milliseconds</returns>
        ''' <remarks></remarks>
        <DispId(1)> Property Interval() As Integer
        ''' <summary>
        ''' Enable the timer tick events
        ''' </summary>
        ''' <value>True means the timer is active and will deliver Tick events every Interval milliseconds.</value>
        ''' <returns>Enabled state of timer tick events</returns>
        ''' <remarks></remarks>
        <DispId(2)> Property Enabled() As Boolean
    End Interface 'Interface to Utilities.Timer

    ''' <summary>
    ''' Timer event interface
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("BDDA4DFD-77F8-4bd2-ACC0-AF32B4F8B9C2"),
    InterfaceType(ComInterfaceType.InterfaceIsIDispatch),
    ComVisible(True)>
    Public Interface ITimerEvent
        ''' <summary>
        ''' Fired once per Interval when timer is Enabled.
        ''' </summary>
        ''' <remarks>To sink this event in Visual Basic, declare the object variable using the WithEvents keyword.</remarks>
        <DispId(1)> Sub Tick()
    End Interface

    ''' <summary>
    ''' Interface to the .NET Profile component
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("3503C303-B268-4da8-A0AA-CD6530B802AA"),
    ComVisible(True)>
    Public Interface IProfile
        'Interface for the Profile class
        ''' <summary>
        ''' The type of ASCOM device for which profile data and registration services are provided 
        ''' (String, default = "Telescope")
        ''' </summary>
        ''' <value>String describing the type of device being accessed</value>
        ''' <returns>String describing the type of device being accessed</returns>
        ''' <remarks></remarks>
        <DispId(1)> Property DeviceType() As String

        ''' <summary>
        ''' List the device types registered in the Profile store
        ''' </summary>
        ''' <value>List of registered device types</value>
        ''' <returns>An ArrayList of device types</returns>
        ''' <remarks>Use this to find which types of device are registered in the Profile store.</remarks>
        <DispId(2)> ReadOnly Property RegisteredDeviceTypes() As ArrayList

        ''' <summary>
        ''' List the devices of a given device type that are registered in the Profile store
        ''' </summary>
        ''' <param name="DeviceType">Type of devices to list</param>
        ''' <returns>An ArrayList of KeyValuePair objects of installed devices and associated device descriptions</returns>
        ''' <exception cref="Exceptions.InvalidValueException">Throw if the supplied DeviceType is empty string or 
        ''' null value.</exception>
        ''' <remarks>
        ''' Use this to find all the registerd devices of a given type that are in the Profile store.
        ''' <para>If a DeviceType is supplied, where no device of that type has been registered before on this system,
        ''' an empty list will be returned</para>
        ''' <para><b>Platform 6</b> Profile.RegisteredDevices was introduced in Platform 5.5 as a read only property that took
        ''' DeviceType as a parameter, which is legal syntax in Visual Basic .NET but is not interpreted correctly in C#. Consequently, 
        ''' a breaking change has been introduced in Platform 6 that changes the property into a parameterised method which works correctly in 
        ''' all .NET languages.</para>
        ''' <para>This change does not require you to alter your source code but you may need to recompile your application under Platform 6
        ''' to ensure that there are no runtime errors.</para>
        ''' </remarks>
        <DispId(3)> Function RegisteredDevices(ByVal DeviceType As String) As ArrayList

        ''' <summary>
        ''' Confirms whether a specific driver is registered ort unregistered in the profile store
        ''' </summary>
        ''' <param name="DriverID">String reprsenting the device's ProgID</param>
        ''' <returns>Boolean indicating registered or unregisteredstate of the supplied DriverID</returns>
        ''' <remarks></remarks>
        <DispId(4)> Function IsRegistered(ByVal DriverID As String) As Boolean

        ''' <summary>
        ''' Registers a supplied DriverID and associates a descriptive name with the device
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to register</param>
        ''' <param name="DescriptiveName">Descriptive name of the device</param>
        ''' <remarks>Does nothing if already registered, so safe to call on driver load.</remarks>
        <DispId(5)> Sub Register(ByVal DriverID As String, ByVal DescriptiveName As String)

        ''' <summary>
        ''' Remove all data for the given DriverID from the registry.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to unregister</param>
        ''' <remarks>This deletes the entire device profile tree, including the DriverID root key.</remarks>
        <DispId(6)> Sub Unregister(ByVal DriverID As String)

        ''' <summary>
        ''' Retrieve a string value from the profile using the supplied subkey for the given Driver ID 
        ''' and variable name. Set and return the default value if the requested variable name has not yet been set.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <param name="SubKey">Subkey from the profile root from which to read the value</param>
        ''' <param name="DefaultValue">Default value to be used if there is no value currently set</param>
        ''' <returns>Retrieved variable value</returns>
        ''' <remarks>
        ''' <para>Name may be an empty string for the unnamed value. The unnamed value is also known as the "default" value for a registry key.</para>
        ''' <para>Does not provide access to other registry data types such as binary and doubleword. </para>
        ''' <para>If a default value is supplied and the value is not already present in the profile store,
        ''' the default value will be set in the profile store and then returned as the value of the 
        ''' DriverID/SubKey/Name. If the default value is set to null (C#) or Nothing (VB) then no value will
        ''' be set in the profile and an empty string will be returned as the value of the 
        ''' DriverID/SubKey/Name.</para>
        ''' </remarks>
        <DispId(7)> Overloads Function GetValue(ByVal DriverID As String, ByVal Name As String, ByVal SubKey As String, ByVal DefaultValue As String) As String

        ''' <summary>
        ''' Writes a string value to the profile using the supplied subkey for the given Driver ID and variable name.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <param name="Value">The string value to be written</param>
        ''' <param name="SubKey">Subkey from the profile root in which to write the value</param>
        ''' <remarks></remarks>
        <DispId(8)> Overloads Sub WriteValue(ByVal DriverID As String, ByVal Name As String, ByVal Value As String, ByVal SubKey As String)

        ''' <summary>
        ''' Return a list of the (unnamed and named variables) under the given DriverID and subkey.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="SubKey">Subkey from the profile root from which to return values</param>
        ''' <returns>An ArrayList of KeyValuePair objects.</returns>
        ''' <remarks>The returned object contains entries for each value. For each entry, 
        ''' the Key property is the value's name, and the Value property is the string value itself. Note that the unnamed (default) 
        ''' value will be included if it has a value, even if the value is a blank string. The unnamed value will have its entry's 
        ''' Key property set to an empty string.
        ''' <para>The KeyValuePair objects are instances of the <see cref="KeyValuePair">KeyValuePair class</see></para>
        '''  </remarks>
        <DispId(9)> Function Values(ByVal DriverID As String, ByVal SubKey As String) As ArrayList

        ''' <summary>
        ''' Delete the value from the registry. Name may be an empty string for the unnamed value. Value will be deleted from the subkey supplied.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <param name="SubKey">Subkey from the profile root in which to write the value</param>
        ''' <remarks>Specify "" to delete the unnamed value which is also known as the "default" value for a registry key. </remarks>
        <DispId(10)> Overloads Sub DeleteValue(ByVal DriverID As String, ByVal Name As String, ByVal SubKey As String)

        ''' <summary>
        ''' Create a registry key for the given DriverID.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="SubKey">Subkey from the profile root in which to write the value</param>
        ''' <remarks>If the SubKey argument contains a \ separated path, the intermediate keys will be created if needed. </remarks>
        <DispId(11)> Sub CreateSubKey(ByVal DriverID As String, ByVal SubKey As String)

        ''' <summary>
        ''' Return a list of the sub-keys under the given DriverID (for COM clients)
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="SubKey">Subkey from the profile root in which to search for subkeys</param>
        ''' <returns>An ArrayList of key-value pairs</returns>
        ''' <remarks>The returned object (scripting.dictionary) contains entries for each sub-key. For each KeyValuePair in the list, 
        ''' the Key property is the sub-key name, and the Value property is the value. The unnamed ("default") value for that key is also returned.
        ''' <para>The KeyValuePair objects are instances of the <see cref="KeyValuePair">KeyValuePair class</see></para>
        ''' </remarks>
        <DispId(12)> Overloads Function SubKeys(ByVal DriverID As String, ByVal SubKey As String) As ArrayList

        ''' <summary>
        ''' Delete a registry key for the given DriverID. SubKey may contain \ separated path to key to be deleted.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="SubKey">Subkey from the profile root in which to write the value</param>
        ''' <remarks>The sub-key and all data and keys beneath it are deleted.</remarks>
        <DispId(13)> Sub DeleteSubKey(ByVal DriverID As String, ByVal SubKey As String)

        ''' <summary>
        ''' Read an entire device profile
        ''' </summary>
        ''' <param name="deviceId">The ProgID of the device</param>
        ''' <returns>Device profile encoded in XML</returns>
        ''' <exception cref="ASCOM.MethodNotImplementedException">This method will be implemented in a future update</exception>
        ''' <remarks>This is not implemented and returns a MethodNotImplemented exception,
        ''' it will be implemented in a future update. An XML schema will also be made available to support 
        ''' this method.</remarks>
        <DispId(14)> Overloads Function GetProfileXML(ByVal deviceId As String) As String

        ''' <summary>
        ''' Set an entire device profile
        ''' </summary>
        ''' <param name="deviceId">The ProgID of the device</param>
        ''' <param name="xml">An XML encoding of the profile</param>
        ''' <exception cref="ASCOM.MethodNotImplementedException">This method will be implemented in a future update</exception>
        ''' <remarks>This is not implemented and returns a MethodNotImplemented exception,
        ''' it will be implemented in a future update. An XML schema will also be made available to support 
        ''' this method.</remarks>
        <DispId(15)> Overloads Sub SetProfileXML(ByVal deviceId As String, ByVal xml As String)

    End Interface 'Interface to Utilities.Profile

    ''' <summary>
    ''' Addiitonal methods that are only visible to .NET clients and not to COM clients
    ''' </summary>
    ''' <remarks></remarks>
    <ComVisible(False)> Public Interface IProfileExtra

        ''' <summary>
        ''' Migrate the ASCOM profile from registry to file store
        ''' </summary>
        ''' <param name="CurrentPlatformVersion">The platform version number of the current profile store beig migrated</param>
        ''' <remarks></remarks>
        <EditorBrowsable(EditorBrowsableState.Never)>
        Sub MigrateProfile(ByVal CurrentPlatformVersion As String)

        ''' <summary>
        ''' Delete the value from the registry. Name may be an empty string for the unnamed value. 
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <remarks>Specify "" to delete the unnamed value which is also known as the "default" value for a registry key.
        ''' <para>This overload is not available through COM, please use 
        ''' "DeleteValue(ByVal DriverID As String, ByVal Name As String, ByVal SubKey As String)"
        ''' with SubKey set to empty string achieve this effect.</para>
        ''' </remarks>
        Overloads Sub DeleteValue(ByVal DriverID As String, ByVal Name As String)

        ''' <summary>
        ''' Retrieve a string value from the profile for the given Driver ID and variable name
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <returns>Retrieved variable value</returns>
        ''' <remarks>
        ''' <para>Name may be an empty string for the unnamed value. The unnamed value is also known as the "default" value for a registry key.</para>
        ''' <para>Does not provide access to other registry data types such as binary and doubleword. </para>
        ''' <para>This overload is not available through COM, please use 
        ''' "GetValue(ByVal DriverID As String, ByVal Name As String, ByVal SubKey As String)"
        ''' with SubKey set to empty string achieve this effect.</para>
        ''' </remarks>
        Overloads Function GetValue(ByVal DriverID As String, ByVal Name As String) As String

        ''' <summary>
        ''' Retrieve a string value from the profile using the supplied subkey for the given Driver ID and variable name.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <param name="SubKey">Subkey from the profile root from which to read the value</param>
        ''' <returns>Retrieved variable value</returns>
        ''' <remarks>
        ''' <para>Name may be an empty string for the unnamed value. The unnamed value is also known as the "default" value for a registry key.</para>
        ''' <para>Does not provide access to other registry data types such as binary and doubleword. </para>
        ''' </remarks>
        Overloads Function GetValue(ByVal DriverID As String, ByVal Name As String, ByVal SubKey As String) As String

        ''' <summary>
        ''' Return a list of the sub-keys under the root of the given DriverID
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <returns>An ArrayList of key-value pairs</returns>
        ''' <remarks>The returned object (scripting.dictionary) contains entries for each sub-key. For each KeyValuePair in the list, 
        ''' the Key property is the sub-key name, and the Value property is the value. The unnamed ("default") value for that key is also returned.
        ''' <para>The KeyValuePair objects are instances of the <see cref="KeyValuePair">KeyValuePair class</see></para>
        ''' </remarks>
        Overloads Function SubKeys(ByVal DriverID As String) As ArrayList

        ''' <summary>
        ''' Return a list of the (unnamed and named variables) under the given DriverID.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <returns>An ArrayList of KeyValuePair objects.</returns>
        ''' <remarks>The returned object contains entries for each value. For each entry, 
        ''' the Key property is the value's name, and the Value property is the string value itself. Note that the unnamed (default) 
        ''' value will be included if it has a value, even if the value is a blank string. The unnamed value will have its entry's 
        ''' Key property set to an empty string.
        ''' <para>The KeyValuePair objects are instances of the <see cref="KeyValuePair">KeyValuePair class</see></para>
        '''  </remarks>
        Overloads Function Values(ByVal DriverID As String) As ArrayList

        ''' <summary>
        ''' Writes a string value to the profile using the given Driver ID and variable name.
        ''' </summary>
        ''' <param name="DriverID">ProgID of the device to read from</param>
        ''' <param name="Name">Name of the variable whose value is retrieved</param>
        ''' <param name="Value">The string value to be written</param>
        ''' <remarks>
        ''' This overload is not available through COM, please use 
        ''' "WriteValue(ByVal DriverID As String, ByVal Name As String, ByVal Value As String, ByVal SubKey As String)"
        ''' with SubKey set to empty string achieve this effect.
        ''' </remarks>
        Overloads Sub WriteValue(ByVal DriverID As String, ByVal Name As String, ByVal Value As String)
        ''' <summary>
        ''' Read an entire device profile and return it as an XML encoded string
        ''' </summary>
        ''' <param name="DriverId">The ProgID of the device</param>
        ''' <returns>Device profile represented as a recusrive class</returns>
        ''' <remarks>Returns a whole driver profile encoded as an XML string</remarks>
        Overloads Function GetProfile(ByVal DriverId As String) As ASCOMProfile

        ''' <summary>
        ''' Set an entire device profile from an XML encoded string
        ''' </summary>
        ''' <param name="DriverId">The ProgID of the device</param>
        ''' <param name="XmlProfileKey">A class representing the profile</param>
        ''' <remarks>Set a whole device Profile in one call using a recusrive ProfileKey class</remarks>
        Sub SetProfile(ByVal DriverId As String, ByVal XmlProfileKey As ASCOMProfile)
    End Interface

    ''' <summary>
    ''' Interface to the .NET Serial component
    ''' </summary>
    ''' <remarks></remarks>
    <Guid("8828511A-05C1-43c7-8970-00D23595930A"),
    ComVisible(True)>
    Public Interface ISerial

        'Interface for the standard ASCOM serial functionality
        ''' <summary>
        ''' Returns a list of all available ASCOM serial ports with COMnnn ports sorted into ascending port number order
        ''' </summary>
        ''' <value>String array of available serial ports</value>
        ''' <returns>A string array of available serial ports</returns>
        ''' <remarks><b>Update in platform 6.0.0.0</b> This call uses the .NET Framework to retrieve available 
        ''' COM ports and this has been found not to return names of some USB serial adapters. Additional 
        ''' code has been added to attempt to open all COM ports up to COM32. Any ports that can be 
        ''' successfully opened are now returned alongside the ports returned by the .NET call.
        ''' <para>If this new approach still does not detect a COM port it can be forced to appear in the list by adding its name
        ''' as a string entry in the ForceCOMPorts key of the ASCOM Profile. In the event that this scanning causes issues, a COM port can be 
        ''' omitted from the scan by adding its name as a string entry in the IgnoreCOMPorts key of the ASCOM Profile.</para></remarks>
        <DispId(1)> ReadOnly Property AvailableComPorts() As String()
        ''' <summary>
        ''' Gets or sets the number of data bits in each byte
        ''' </summary>
        ''' <value>The number of data bits in each byte, default is 8 data bits</value>
        ''' <returns>Integer number of data bits in each byte</returns>
        ''' <exception cref="ArgumentOutOfRangeException">The data bits value is less than 5 or more than 8</exception>
        ''' <remarks></remarks>
        <DispId(2)> Property DataBits() As Integer
        ''' <summary>
        ''' Gets or sets the state of the DTR line
        ''' </summary>
        ''' <value>The state of the DTR line, default is enabled</value>
        ''' <returns>Boolean true/false indicating enabled/disabled</returns>
        ''' <remarks></remarks>
        <DispId(3)> Property DTREnable() As Boolean
        ''' <summary>
        ''' Gets or sets the type of parity check used over the serial link
        ''' </summary>
        ''' <value>The type of parity check used over the serial link, default none</value>
        ''' <returns>One of the Ports.Parity enumeration values</returns>
        ''' <remarks></remarks>
        <DispId(4)> Property Parity() As SerialParity
        ''' <summary>
        ''' Gets or sets the number of stop bits used on the serial link
        ''' </summary>
        ''' <value>the number of stop bits used on the serial link, default 1</value>
        ''' <returns>One of the Ports.StopBits enumeration values</returns>
        ''' <remarks></remarks>
        <DispId(5)> Property StopBits() As SerialStopBits
        ''' <summary>
        ''' Gets or sets the type of serial handshake used on the serial line
        ''' </summary>
        ''' <value>The type of handshake used on the serial line, default is none</value>
        ''' <returns>One of the Ports.Handshake enumeration values</returns>
        ''' <remarks>Use of the RTS line can additionally be controlled by the <see cref="Handshake"/> property.</remarks>
        <DispId(6)> Property Handshake() As SerialHandshake
        ''' <summary>
        ''' Gets or sets the connected state of the ASCOM serial port.
        ''' </summary>
        ''' <value>Connected state of the serial port.</value>
        ''' <returns><c>True</c> if the serial port is connected.</returns>
        ''' <remarks>Set this property to True to connect to the serial (COM) port. You can read the property to determine if the object is connected. </remarks>
        <DispId(7)> Property Connected() As Boolean
        ''' <summary>
        ''' Gets or sets the number of the ASCOM serial port (Default is 1, giving COM1 as the serial port name).
        ''' </summary>
        ''' <value>COM port number of the ASCOM serial port.</value>
        ''' <returns>Integer, number of the ASCOM serial port</returns>
        ''' <remarks>This works for serial port names of the form COMnnn. Use PortName if your COM port name does not fit the form COMnnn.</remarks>
        <DispId(8)> Property Port() As Integer
        ''' <summary>
        ''' The maximum time that the ASCOM serial port will wait for incoming receive data (seconds, default = 5)
        ''' </summary>
        ''' <value>Integer, serial port timeout in seconds</value>
        ''' <returns>Integer, serial port timeout in seconds.</returns>
        ''' <remarks>The minimum delay timout that can be set through this command is 1 seconds. Use ReceiveTimeoutMs to set a timeout less than 1 second.</remarks>
        <DispId(9)> Property ReceiveTimeout() As Integer
        ''' <summary>
        ''' The maximum time that the ASCOM serial port will wait for incoming receive data (milliseconds, default = 5000)
        ''' </summary>
        ''' <value>Integer, serial port timeout in milli-seconds</value>
        ''' <returns>Integer, serial port timeout in milli-seconds</returns>
        ''' <remarks>If a timeout occurs, an IO timeout error is raised. See ReceiveTimeout for an alternate form 
        ''' using the timeout in seconds. </remarks>
        <DispId(10)> Property ReceiveTimeoutMs() As Integer
        ''' <summary>
        ''' Sets the ASCOM serial port name as a string
        ''' </summary>
        ''' <value>Serial port name to be used</value>
        ''' <returns>Current serial port name</returns>
        ''' <remarks>This property allows any serial port name to be used, even if it doesn't conform to a format of COMnnn
        ''' If the required port name is of the form COMnnn then Serial.Port=nnn and Serial.PortName="COMnnn" are 
        ''' equivalent.</remarks>
        <DispId(11)> Property PortName() As String
        ''' <summary>
        ''' Gets and sets the baud rate of the ASCOM serial port
        ''' </summary>
        ''' <value>Port speed using the PorSpeed enum</value>
        ''' <returns>Port speed using the PortSpeed enum</returns>
        ''' <remarks>This is modelled on the COM component with possible values enumerated in the PortSpeed enum.</remarks>
        <DispId(12)> Property Speed() As SerialSpeed
        ''' <summary>
        ''' Clears the ASCOM serial port receive and transmit buffers
        ''' </summary>
        ''' <remarks></remarks>
        <DispId(13)> Sub ClearBuffers()
        ''' <summary>
        ''' Transmits a string through the ASCOM serial port
        ''' </summary>
        ''' <param name="Data">String to transmit</param>
        ''' <remarks></remarks>
        <DispId(14)> Sub Transmit(ByVal Data As String)
        ''' <summary>
        ''' Transmit an array of binary bytes through the ASCOM serial port 
        ''' </summary>
        ''' <param name="Data">Byte array to transmit</param>
        ''' <remarks></remarks>
        <DispId(15)> Sub TransmitBinary(ByVal Data As Byte())
        ''' <summary>
        ''' Adds a message to the ASCOM serial trace file
        ''' </summary>
        ''' <param name="Caller">String identifying the module logging the message</param>
        ''' <param name="Message">Message text to be logged.</param>
        ''' <remarks>
        ''' <para>This can be called regardless of whether logging is enabled</para>
        ''' </remarks>
        <DispId(16)> Sub LogMessage(ByVal Caller As String, ByVal Message As String)
        ''' <summary>
        ''' Receive at least one text character from the ASCOM serial port
        ''' </summary>
        ''' <returns>The characters received</returns>
        ''' <remarks>This method reads all of the characters currently in the serial receive buffer. It will not return 
        ''' unless it reads at least one character. A timeout will cause a TimeoutException to be raised. Use this for 
        ''' text data, as it returns a String. </remarks>
        <DispId(17)> Function Receive() As String
        ''' <summary>
        ''' Receive one binary byte from the ASCOM serial port
        ''' </summary>
        ''' <returns>The received byte</returns>
        ''' <remarks>Use this for 8-bit (binary data). If a timeout occurs, a TimeoutException is raised. </remarks>
        <DispId(18)> Function ReceiveByte() As Byte
        ''' <summary>
        ''' Receive exactly the given number of characters from the ASCOM serial port and return as a string
        ''' </summary>
        ''' <param name="Count">The number of characters to return</param>
        ''' <returns>String of length "Count" characters</returns>
        ''' <remarks>If a timeout occurs a TimeoutException is raised.</remarks>
        <DispId(19)> Function ReceiveCounted(ByVal Count As Integer) As String
        ''' <summary>
        ''' Receive exactly the given number of characters from the ASCOM serial port and return as a byte array
        ''' </summary>
        ''' <param name="Count">The number of characters to return</param>
        ''' <returns>Byte array of size "Count" elements</returns>
        ''' <remarks>
        ''' <para>If a timeout occurs, a TimeoutException is raised. </para>
        ''' <para>This function exists in the COM component but is not documented in the help file.</para>
        ''' </remarks>
        <DispId(20)> Function ReceiveCountedBinary(ByVal Count As Integer) As Byte()
        ''' <summary>
        ''' Receive characters from the ASCOM serial port until the given terminator string is seen
        ''' </summary>
        ''' <param name="Terminator">The character string that indicates end of message</param>
        ''' <returns>Received characters including the terminator string</returns>
        ''' <remarks>If a timeout occurs, a TimeoutException is raised.</remarks>
        <DispId(21)> Function ReceiveTerminated(ByVal Terminator As String) As String
        ''' <summary>
        ''' Receive characters from the ASCOM serial port until the given terminator bytes are seen, return as a byte array
        ''' </summary>
        ''' <param name="TerminatorBytes">Array of bytes that indicates end of message</param>
        ''' <returns>Byte array of received characters</returns>
        ''' <remarks>
        ''' <para>If a timeout occurs, a TimeoutException is raised.</para>
        ''' <para>This function exists in the COM component but is not documented in the help file.</para>
        ''' </remarks>
        <DispId(22)> Function ReceiveTerminatedBinary(ByVal TerminatorBytes() As Byte) As Byte()
        ''' <summary>
        ''' Gets or sets use of the RTS handshake control line
        ''' </summary>
        ''' <value>The state of RTS line use, default is disabled (false)</value>
        ''' <returns>Boolean true/false indicating RTS line use enabled/disabled</returns>
        ''' <remarks>By default the serial component will not drive the RTS line. If RTSEnable is true, the RTS line will be raised before
        ''' characters are sent. Please also see the associated <see cref="Handshake"/> property.</remarks>
        <DispId(23)> Property RTSEnable() As Boolean
    End Interface  'Interface to Utilities.Serial

#End Region

#Region "Utilities Private Interfaces"

    Friend Interface IFileStoreProvider
        'Interface that a file store provider must implement to support a storage provider
        Sub CreateDirectory(ByVal p_SubKeyName As String, ByVal p_TL As TraceLogger)
        Sub DeleteDirectory(ByVal p_SubKeyName As String)
        Sub EraseFileStore()
        ReadOnly Property GetDirectoryNames(ByVal p_SubKeyName As String) As String()
        ReadOnly Property Exists(ByVal p_FileName As String) As Boolean
        ReadOnly Property FullPath(ByVal p_FileName As String) As String
        ReadOnly Property BasePath() As String
        Sub Rename(ByVal p_CurrentName As String, ByVal p_NewName As String)
        Sub RenameDirectory(ByVal CurrentName As String, ByVal NewName As String)
        Sub SetSecurityACLs(ByVal p_TL As TraceLogger)
    End Interface 'Interface that a file store provider must implement to support a store provider

    Friend Interface IAccess
        'Interface for a general profile store provider, this is independent of the actual mechanic used to store the profile
        Overloads Function GetProfile(ByVal p_SubKeyName As String, ByVal p_ValueName As String) As String
        Overloads Function GetProfile(ByVal p_SubKeyName As String, ByVal p_ValueName As String, ByVal p_DefaultValue As String) As String
        Sub WriteProfile(ByVal p_SubKeyName As String, ByVal p_ValueName As String, ByVal p_ValueData As String)
        Function EnumProfile(ByVal p_SubKeyName As String) As Generic.SortedList(Of String, String)
        Sub DeleteProfile(ByVal p_SubKeyName As String, ByVal p_ValueName As String)
        Sub CreateKey(ByVal p_SubKeyName As String)
        Function EnumKeys(ByVal p_SubKeyName As String) As Generic.SortedList(Of String, String)
        Sub DeleteKey(ByVal p_SubKeyName As String)
        Sub RenameKey(ByVal CurrentSubKeyName As String, ByVal NewSubKeyName As String)
        Sub MigrateProfile(ByVal CurrentPlatformVersion As String)
        Sub SetProfile(ByVal DriverId As String, ByVal XmlProfile As ASCOMProfile)
        Overloads Function GetProfile(ByVal DriverId As String) As ASCOMProfile
    End Interface 'Interface for a general profile store provider

#End Region

End Namespace