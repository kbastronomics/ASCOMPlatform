﻿Imports System.Runtime.InteropServices
Imports System.Collections

'-----------------------------------------------------------------------
' <summary>Defines the ITelescope Interface</summary>
'-----------------------------------------------------------------------
''' <summary>
''' Defines the ITelescope Interface
''' </summary>
<ComVisible(True), Guid("A007D146-AE3D-4754-98CA-199FEC03CF68"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)> _
Public Interface ITelescopeV3 ' EF0C67AD-A9D3-4f7b-A635-CD2095517633

#Region "Common Methods"
    ''' <summary>
    ''' Set True to connect to the device. Set False to disconnect from the device.
    ''' You can also read the property to check whether the device is connected.
    ''' </summary>
    ''' <value><c>true</c> if connected; otherwise, <c>false</c>.</value>
    ''' <exception cref="DriverException">Must throw exception if unsuccessful.</exception>
    Property Connected() As Boolean

    ''' <summary>
    ''' Returns a description of the driver, such as manufacturer and model
    ''' number. Any ASCII characters may be used. For Camera devices, the string shall not exceed 68
    ''' characters (for compatibility with FITS headers).
    ''' </summary>
    ''' <value>The description.</value>
    ''' <exception cref="DriverException">Must throw an exception if description unavailable</exception>
    ReadOnly Property Description() As String

    ''' <summary>
    ''' Descriptive and version information about this ASCOM driver.
    ''' This string may contain line endings and may be hundreds to thousands of characters long.
    ''' It is intended to display detailed information on the ASCOM driver, including version and copyright data.
    ''' See the Description property for descriptive info on the telescope itself.
    ''' To get the driver version in a parseable string, use the DriverVersion property.
    ''' </summary>
    ReadOnly Property DriverInfo() As String

    ''' <summary>
    ''' A string containing only the major and minor version of the driver.
    ''' This must be in the form "n.n".
    ''' Not to be confused with the InterfaceVersion property, which is the version of the ASCOM specification supported by the driver.
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </summary>
    ReadOnly Property DriverVersion() As String

    ''' <summary>
    ''' The ASCOM device interface version that this driver supports.
    ''' This is not implemented in Telescope Interface version 1, these will raise an error,
    ''' this should be interpreted as InterfaceVersion 1
    ''' </summary>
    ReadOnly Property InterfaceVersion() As Short

    ''' <summary>
    ''' The short name of the driver, for display purposes
    ''' </summary>
    ReadOnly Property Name() As String

    ''' <summary>
    ''' Launches a configuration dialog box for the driver.  The call will not return
    ''' until the user clicks OK or cancel manually.
    ''' </summary>
    ''' <exception cref="MethodNotImplementedException">Must throw an exception if Setup dialog is unavailable.</exception>
    Sub SetupDialog()

    ''' <summary>
    ''' Invokes the specified device-specific action.
    ''' </summary>
    ''' <param name="ActionName">
    ''' A well known name agreed by interested parties that represents the action to be carried out. 
    ''' </param>
    ''' <param name="ActionParameters">List of required parameters or an <see cref="String.Empty">Empty String</see> if none are required.
    ''' </param>
    ''' <returns>A string response. The meaning of returned strings is set by the driver author.</returns>
    ''' <example>Suppose filter wheels start to appear with automatic wheel changers; new actions could 
    ''' be “FilterWheel:QueryWheels” and “FilterWheel:SelectWheel”. The former returning a 
    ''' formatted list of wheel names and the second taking a wheel name and making the change, returning appropriate 
    ''' values to indicate success or failure.
    ''' </example>
    ''' <remarks>
    ''' This method is intended for use in all current and future device types and to avoid name clashes, management of action names 
    ''' is important from day 1. A two-part naming convention will be adopted - <b>DeviceType:UniqueActionName</b> where:
    ''' <list type="bullet">
    ''' <item><description>DeviceType is the same value as would be used by <see cref="ASCOM.Utilities.Chooser.DeviceType"/> e.g. Telescope, Camera, Switch etc.</description></item>
    ''' <item><description>UniqueActionName is a single word, or multiple words joined by underscore characters, that sensibly describes the action to be performed.</description></item>
    ''' </list>
    ''' <para>
    ''' It is recommended that UniqueActionNames should be a maximum of 16 characters for legibility.
    ''' Should the same function and UniqueActionName be supported by more than one type of device, the reserved DeviceType of 
    ''' “General” will be used. Action names will be case insensitive, so FilterWheel:SelectWheel, filterwheel:selectwheel 
    ''' and FILTERWHEEL:SELECTWHEEL will all refer to the same action.</para>
    ''' <para>The names of all supported actions must bre returned in the <see cref="SupportedActions"/> property.</para>
    ''' </remarks>
    ''' <exception cref="ASCOM.MethodNotImplementedException">Throws this exception if no actions are suported.</exception>
    ''' <exception cref="ASCOM.ActionNotImplementedException">It is intended that the SupportedActions method will inform clients 
    ''' of driver capabilities, but the driver must still throw an ASCOM.ActionNotImplemented exception if it is asked to 
    ''' perform an action that it does not support.</exception>
    Function Action(ByVal ActionName As String, ByVal ActionParameters As String) As String

    ''' <summary>
    ''' Returns the list of action names supported by this driver. This is only available for telescope InterfaceVersion 3
    ''' </summary>
    ''' <value>An ArrayList of strings (SafeArray collection) containing the names of supported actions.</value>
    ''' <remarks>This method must return an empty arraylist if no actions are supported. Please do not throw a 
    ''' <see cref="ASCOM.PropertyNotImplementedException" />.
    ''' <para>This is an aid to client authors and testers who would otherwise have to repeatedly poll the driver to determine its capabilities. 
    ''' Returned action names may be in mixed case to enhance presentation but  will be recognised case insensitively in 
    ''' the <see cref="Action"/> method.</para>
    '''<para>An array list collection has been selected as the vehicle for  action names in order to make it easier for clients to
    ''' determine whether a particular action is supported. This is easily done through the Contains method. Since the
    ''' collection is also ennumerable it is easy to use constructs such as For Each ... to operate on members without having to be concerned 
    ''' about hom many members are in the collection. </para>
    ''' <para>Collections have been used in the Telescope specification for a number of years and are known to be compatible with COM. Within .NET
    ''' the ArrayList is the correct implementation to use as the .NET Generic methods are not compatible with COM.</para>
    ''' </remarks> 
    ReadOnly Property SupportedActions() As ArrayList

    ''' <summary>
    ''' Transmits an arbitrary string to the device and does not wait for a response.
    ''' Optionally, protocol framing characters may be added to the string before transmission.
    ''' </summary>
    ''' <param name="Command">The literal command string to be transmitted.</param>
    ''' <param name="Raw">
    ''' if set to <c>true</c> the string is transmitted 'as-is'.
    ''' If set to <c>false</c> then protocol framing characters may be added prior to transmission.
    ''' </param>
    Sub CommandBlind(ByVal Command As String, Optional ByVal Raw As Boolean = False)

    ''' <summary>
    ''' Transmits an arbitrary string to the device and waits for a boolean response.
    ''' Optionally, protocol framing characters may be added to the string before transmission.
    ''' </summary>
    ''' <param name="Command">The literal command string to be transmitted.</param>
    ''' <param name="Raw">
    ''' if set to <c>true</c> the string is transmitted 'as-is'.
    ''' If set to <c>false</c> then protocol framing characters may be added prior to transmission.
    ''' </param>
    ''' <returns>
    ''' Returns the interpreted boolean response received from the device.
    ''' </returns>
    Function CommandBool(ByVal Command As String, Optional ByVal Raw As Boolean = False) As Boolean

    ''' <summary>
    ''' Transmits an arbitrary string to the device and waits for a string response.
    ''' Optionally, protocol framing characters may be added to the string before transmission.
    ''' </summary>
    ''' <param name="Command">The literal command string to be transmitted.</param>
    ''' <param name="Raw">
    ''' if set to <c>true</c> the string is transmitted 'as-is'.
    ''' If set to <c>false</c> then protocol framing characters may be added prior to transmission.
    ''' </param>
    ''' <returns>
    ''' Returns the string response received from the device.
    ''' </returns>
    Function CommandString(ByVal Command As String, Optional ByVal Raw As Boolean = False) As String

    ''' <summary>
    ''' Dispose the late-bound interface, if needed. Will release it via COM
    ''' if it is a COM object, else if native .NET will just dereference it
    ''' for GC.
    ''' </summary>
    Sub Dispose()

#End Region

#Region "Device Methods"
    ''' <summary>
    ''' Stops a slew in progress.
    ''' </summary>
    ''' <remarks>
    ''' Effective only after a call to <see cref="SlewToTargetAsync" />, <see cref="SlewToCoordinatesAsync" />, <see cref="SlewToAltAzAsync" />, or <see cref="MoveAxis" />.
    ''' Does nothing if no slew/motion is in progress. 
    ''' Tracking is returned to its pre-slew state.
    ''' Raises an error if <see cref="AtPark" /> is true. 
    ''' </remarks>
    Sub AbortSlew()

    ''' <summary>
    ''' The alignment mode of the mount.
    ''' </summary>
    ''' <remarks>
    ''' This is only available for telescope InterfaceVersions 2 and 3
    ''' </remarks>
    ReadOnly Property AlignmentMode() As AlignmentModes

    ''' <summary>
    ''' The Altitude above the local horizon of the telescope's current position (degrees, positive up)
    ''' </summary>
    ReadOnly Property Altitude() As Double

    ''' <summary>
    ''' The area of the telescope's aperture, taking into account any obstructions (square meters)
    ''' </summary>
    ''' <remarks>
    ''' This is only available for telescope InterfaceVersions 2 and 3
    ''' </remarks>
    ReadOnly Property ApertureArea() As Double

    ''' <summary>
    ''' The telescope's effective aperture diameter (meters)
    ''' </summary>
    ''' <remarks>
    ''' This is only available for telescope InterfaceVersions 2 and 3
    ''' </remarks>
    ReadOnly Property ApertureDiameter() As Double

    ''' <summary>
    ''' True if the telescope is stopped in the Home position. Set only following a <see cref="FindHome"></see> operation,
    '''  and reset with any slew operation. This property must be False if the telescope does not support homing. 
    ''' </summary>
    ''' <remarks>
    ''' This is only available for telescope InterfaceVersions 2 and 3
    ''' </remarks>
    ReadOnly Property AtHome() As Boolean

    ''' <summary>
    ''' True if the telescope has been put into the parked state by the seee <see cref="Park" /> method. Set False by calling the Unpark() method.
    ''' </summary>
    ''' <remarks>
    ''' <para>AtPark is True when the telescope is in the parked state. This is achieved by calling the <see cref="Park" /> method. When AtPark is true, 
    ''' the telescope movement is stopped (or restricted to a small safe range of movement) and all calls that would cause telescope 
    ''' movement (e.g. slewing, changing Tracking state) must not do so, and must raise an error.</para>
    ''' <para>The telescope is taken out of parked state by calling the <see cref="UnPark" /> method. If the telescope cannot be parked, 
    ''' then AtPark must always return False.</para>
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property AtPark() As Boolean

    ''' <summary>
    ''' Determine the rates at which the telescope may be moved about the specified axis by the <see cref="MoveAxis" /> method.
    ''' </summary>
    ''' <remarks>
    ''' See the description of <see cref="MoveAxis" /> for more information. This method must return an empty collection if <see cref="MoveAxis" /> is not supported. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ''' <param name="Axis">The axis about which rate information is desired (TelescopeAxes value)</param>
    ''' <returns>Collection of Axis Rates</returns>
    Function AxisRates(ByVal Axis As TelescopeAxes) As IAxisRates

    ''' <summary>
    ''' The azimuth at the local horizon of the telescope's current position (degrees, North-referenced, positive East/clockwise).
    ''' </summary>
    ReadOnly Property Azimuth() As Double

    ''' <summary>
    ''' True if this telescope is capable of programmed finding its home position (<see cref="FindHome" /> method).
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property CanFindHome() As Boolean

    ''' <summary>
    ''' True if this telescope can move the requested axis
    ''' </summary>
    ''' <remarks>
    ''' This is only available for telescope InterfaceVersions 2 and 3
    ''' </remarks>
    ''' <param name="Axis">Primary, Secondary or Tertiary axis</param>
    ''' <returns>Boolean indicating can or can not move the requested axis</returns>
    Function CanMoveAxis(ByVal Axis As TelescopeAxes) As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed parking (<see cref="Park" />method)
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property CanPark() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of software-pulsed guiding (via the <see cref="PulseGuide" /> method)
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanPulseGuide() As Boolean

    ''' <summary>
    ''' True if the <see cref="DeclinationRate" /> property can be changed to provide offset tracking in the declination axis.
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSetDeclinationRate() As Boolean

    ''' <summary>
    ''' True if the guide rate properties used for <see cref="PulseGuide" /> can ba adjusted.
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property CanSetGuideRates() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed setting of its park position (<see cref="SetPark" /> method)
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property CanSetPark() As Boolean

    ''' <summary>
    ''' True if the <see cref="SideOfPier" /> property can be set, meaning that the mount can be forced to flip.
    ''' </summary>
    ''' <remarks>
    ''' This will always return False for non-German-equatorial mounts that do not have to be flipped. 
    ''' May raise an error if the telescope is not connected. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property CanSetPierSide() As Boolean

    ''' <summary>
    ''' True if the <see cref="RightAscensionRate" /> property can be changed to provide offset tracking in the right ascension axis.
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSetRightAscensionRate() As Boolean

    ''' <summary>
    ''' True if the <see cref="Tracking" /> property can be changed, turning telescope sidereal tracking on and off.
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSetTracking() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed slewing (synchronous or asynchronous) to equatorial coordinates
    ''' </summary>
    ''' <remarks>
    ''' If this is true, then only the synchronous equatorial slewing methods are guaranteed to be supported.
    ''' See the <see cref="CanSlewAsync" /> property for the asynchronous slewing capability flag. 
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSlew() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed slewing (synchronous or asynchronous) to local horizontal coordinates
    ''' </summary>
    ''' <remarks>
    ''' If this is true, then only the synchronous local horizontal slewing methods are guaranteed to be supported.
    ''' See the <see cref="CanSlewAltAzAsync" /> property for the asynchronous slewing capability flag. 
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSlewAltAz() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed asynchronous slewing to local horizontal coordinates
    ''' </summary>
    ''' <remarks>
    ''' This indicates the the asynchronous local horizontal slewing methods are supported.
    ''' If this is True, then <see cref="CanSlewAltAz" /> will also be true. 
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSlewAltAzAsync() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed asynchronous slewing to equatorial coordinates.
    ''' </summary>
    ''' <remarks>
    ''' This indicates the the asynchronous equatorial slewing methods are supported.
    ''' If this is True, then <see cref="CanSlew" /> will also be true.
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSlewAsync() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed synching to equatorial coordinates.
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSync() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed synching to local horizontal coordinates
    ''' </summary>
    ''' <remarks>
    ''' May raise an error if the telescope is not connected. 
    ''' </remarks>
    ReadOnly Property CanSyncAltAz() As Boolean

    ''' <summary>
    ''' True if this telescope is capable of programmed unparking (<see cref="Unpark" /> method).
    ''' </summary>
    ''' <remarks>
    ''' If this is true, then <see cref="CanPark" /> will also be true. May raise an error if the telescope is not connected.
    ''' May raise an error if the telescope is not connected. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property CanUnpark() As Boolean

    ''' <summary>
    ''' The declination (degrees) of the telescope's current equatorial coordinates, in the coordinate system given by the <see cref="EquatorialSystem" /> property.
    ''' Reading the property will raise an error if the value is unavailable. 
    ''' </summary>
    ReadOnly Property Declination() As Double

    ''' <summary>
    ''' The declination tracking rate (arcseconds per second, default = 0.0)
    ''' </summary>
    ''' <remarks>
    ''' This property, together with <see cref="RightAscensionRate" />, provides support for "offset tracking".
    ''' Offset tracking is used primarily for tracking objects that move relatively slowly against the equatorial coordinate system.
    ''' It also may be used by a software guiding system that controls rates instead of using the <see cref="PulseGuide">PulseGuide</see> method. 
    ''' <para>
    ''' <b>NOTES:</b>
    ''' <list type="bullet">
    ''' <list></list>
    ''' <item><description>The property value represents an offset from zero motion.</description></item>
    ''' <item><description>If <see cref="CanSetDeclinationRate" /> is False, this property will always return 0.</description></item>
    ''' <item><description>To discover whether this feature is supported, test the <see cref="CanSetDeclinationRate" /> property.</description></item>
    ''' <item><description>The supported range of this property is telescope specific, however, if this feature is supported,
    ''' it can be expected that the range is sufficient to allow correction of guiding errors caused by moderate misalignment 
    ''' and periodic error.</description></item>
    ''' <item><description>If this property is non-zero when an equatorial slew is initiated, the telescope should continue to update the slew 
    ''' destination coordinates at the given offset rate.</description></item>
    ''' <item><description>This will allow precise slews to a fast-moving target with a slow-slewing telescope.</description></item>
    ''' <item><description>When the slew completes, the <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" /> properties should reflect the final (adjusted) destination.</description></item>
    ''' </list>
    ''' </para>
    ''' <para>
    '''This is not a required feature of this specification, however it is desirable. 
    ''' </para>
    ''' </remarks>
    Property DeclinationRate() As Double

    ''' <summary>
    ''' Predict side of pier for German equatorial mounts
    ''' </summary>
    ''' <remarks>
    ''' This is only available for telescope InterfaceVersions 2 and 3
    ''' </remarks>
    ''' <param name="RightAscension">The destination right ascension (hours).</param>
    ''' <param name="Declination">The destination declination (degrees, positive North).</param>
    ''' <returns>The side of the pier on which the telescope would be on if a slew to the given equatorial coordinates is performed at the current instant of time.</returns>
    Function DestinationSideOfPier(ByVal RightAscension As Double, ByVal Declination As Double) As PierSide

    ''' <summary>
    ''' True if the telescope or driver applies atmospheric refraction to coordinates.
    ''' </summary>
    ''' <remarks>
    ''' If this property is True, the coordinates sent to, and retrieved from, the telescope are unrefracted. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' <para>
    ''' <b>NOTES:</b>
    ''' <list type="bullet">
    ''' <item><description>If the driver does not know whether the attached telescope does its own refraction, and if the driver does not itself calculate 
    ''' refraction, this property (if implemented) must raise an error when read.</description></item>
    ''' <item><description>Writing to this property is optional. Often, a telescope (or its driver) calculates refraction using standard atmospheric parameters.</description></item>
    ''' <item><description>If the client wishes to calculate a more accurate refraction, then this property could be set to False and these 
    ''' client-refracted coordinates used.</description></item>
    ''' <item><description>If disabling the telescope or driver's refraction is not supported, the driver must raise an error when an attempt to set 
    ''' this property to False is made.</description></item> 
    ''' <item><description>Setting this property to True for a telescope or driver that does refraction, or to False for a telescope or driver that 
    ''' does not do refraction, shall not raise an error. It shall have no effect.</description></item> 
    ''' </list>
    ''' </para>
    ''' </remarks>
    Property DoesRefraction() As Boolean

    ''' <summary>
    ''' Equatorial coordinate system used by this telescope.
    ''' </summary>
    ''' <remarks>
    ''' Most amateur telescopes use local topocentric coordinates.
    ''' This coordinate system is simply the apparent position in the sky
    ''' (possibly uncorrected for atmospheric refraction) for "here and now",
    ''' thus these are the coordinates that one would use with digital setting
    ''' circles and most amateur scopes. More sophisticated telescopes use one of
    ''' the standard reference systems established by professional astronomers.
    ''' The most common is the Julian Epoch 2000 (J2000). 
    ''' These instruments apply corrections for precession,
    ''' nutation, abberration, etc. to adjust the coordinates from the standard system
    ''' to the pointing direction for the time and location of "here and now". 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property EquatorialSystem() As EquatorialCoordinateType

    ''' <summary>
    ''' Locates the telescope's "home" position (synchronous)
    ''' </summary>
    ''' <remarks>
    ''' Returns only after the home position has been found.
    ''' At this point the <see cref="AtHome" /> property will be True.
    ''' Raises an error if there is a problem. 
    ''' Raises an error if AtPark is true. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    Sub FindHome()

    ''' <summary>
    ''' The telescope's focal length, meters
    ''' </summary>
    ''' <remarks>
    ''' This property may be used by clients to calculate telescope field of view and plate scale when combined with detector pixel size and geometry. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property FocalLength() As Double

    ''' <summary>
    ''' The current Declination movement rate offset for telescope guiding (degrees/sec)
    ''' </summary>
    ''' <remarks>
    ''' This is the rate for both hardware/relay guiding and the PulseGuide() method. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' <para>
    ''' <b>NOTES:</b>
    ''' <list type="bullet">
    ''' <item><description>To discover whether this feature is supported, test the <see cref="CanSetGuideRates" /> property.</description></item> 
    ''' <item><description>The supported range of this property is telescope specific, however,
    ''' if this feature is supported, it can be expected that the range is sufficient to
    ''' allow correction of guiding errors caused by moderate misalignment and periodic error.</description></item> 
    ''' <item><description>If a telescope does not support separate guiding rates in Right Ascension and Declination,
    ''' then it is permissible for <see cref="GuideRateRightAscension" /> and GuideRateDeclination to be tied together.
    ''' In this case, changing one of the two properties will cause a change in the other.</description></item> 
    ''' <item><description>Mounts must start up with a known or default declination guide rate,
    ''' and this property must return that known/default guide rate until changed.</description></item> 
    ''' </list>
    ''' </para>
    ''' </remarks>
    Property GuideRateDeclination() As Double

    ''' <summary>
    ''' The current Right Ascension movement rate offset for telescope guiding (degrees/sec)
    ''' </summary>
    ''' <remarks>
    ''' This is the rate for both hardware/relay guiding and the PulseGuide() method. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' <para>
    ''' <b>NOTES:</b>
    ''' <list type="bullet">
    ''' <item><description>To discover whether this feature is supported, test the <see cref="CanSetGuideRates" /> property.</description></item>  
    ''' <item><description>The supported range of this property is telescope specific, however, if this feature is supported, 
    ''' it can be expected that the range is sufficient to allow correction of guiding errors caused by moderate
    ''' misalignment and periodic error.</description></item>  
    ''' <item><description>If a telescope does not support separate guiding rates in Right Ascension and Declination,
    ''' then it is permissible for GuideRateRightAscension and <see cref="GuideRateDeclination" /> to be tied together. 
    ''' In this case, changing one of the two properties will cause a change in the other.</description></item>  
    '''<item><description> Mounts must start up with a known or default right ascension guide rate,
    ''' and this property must return that known/default guide rate until changed.</description></item>  
    ''' </list>
    ''' </para>
    ''' </remarks>
    Property GuideRateRightAscension() As Double

    ''' <summary>
    ''' True if a <see cref="PulseGuide" /> command is in progress, False otherwise
    ''' </summary>
    ''' <remarks>
    ''' Raises an error if the value of the <see cref="CanPulseGuide" /> property is false
    ''' (the driver does not support the <see cref="PulseGuide" /> method). 
    ''' </remarks>
    ReadOnly Property IsPulseGuiding() As Boolean

    ''' <summary>
    ''' Move the telescope in one axis at the given rate.
    ''' </summary>
    ''' <remarks>
    ''' This method supports control of the mount about its mechanical axes.
    ''' The telescope will start moving at the specified rate about the specified axis and continue indefinitely.
    ''' This method can be called for each axis separately, and have them all operate concurrently at separate rates of motion. 
    ''' Set the rate for an axis to zero to stop the motionabout that axis.
    ''' Tracking motion (if enabled, see note below) is suspended during this mode of operation. 
    ''' <para>
    ''' Raises an error if <see cref="AtPark" /> is true. 
    ''' This must be implemented for the if the <see cref="CanMoveAxis" /> property returns True for the given axis.</para>
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' <para>
    ''' <b>NOTES:</b>
    ''' <list type="bullet">
    ''' <item><description>The movement rate must be within the value(s) obtained from a <see cref="IRate" /> object in the the <see cref="AxisRates" /> collection.</description></item>
    ''' <item><description>An out of range exception is raised the rate is out of range.</description></item>
    ''' <item><description>The value of the <see cref="Slewing" /> must be True if the telescope is moving 
    ''' about any of its axes as a result of this method being called. 
    ''' This can be used to simulate a handbox by initiating motion with the
    ''' MouseDown event and stopping the motion with the MouseUp event.</description></item>
    ''' <item><description>When the motion is stopped the scope will be set to the previous 
    ''' <see cref="TrackingRate" /> or to no movement, depending on the state of the <see cref="Tracking" /> property.</description></item>
    ''' <item><description>It may be possible to implement satellite tracking by using the <see cref="MoveAxis" /> method to move the 
    ''' scope in the required manner to track a satellite.</description></item>
    ''' </list>
    ''' </para>
    ''' </remarks>
    ''' <param name="Axis">The physical axis about which movement is desired</param>
    ''' <param name="Rate">The rate of motion (deg/sec) about the specified axis</param>
    Sub MoveAxis(ByVal Axis As TelescopeAxes, ByVal Rate As Double)

    ''' <summary>
    ''' Move the telescope to its park position, stop all motion (or restrict to a small safe range), and set <see cref="AtPark" /> to True.
    ''' </summary>
    ''' <remarks>
    ''' Raises an error if there is a problem communicating with the telescope or if parking fails. 
    ''' Parking should put the telescope into a state where its pointing accuracy 
    ''' will not be lost if it is power-cycled (without moving it).
    ''' Some telescopes must be power-cycled before unparking.
    ''' Others may be unparked by simply calling the <see cref="UnPark" /> method.
    ''' Calling this with <see cref="AtPark" /> = True does nothing (harmless) 
    ''' </remarks>
    Sub Park()

    ''' <summary>
    ''' Moves the scope in the given direction for the given interval or time at 
    ''' the rate given by the corresponding guide rate property 
    ''' </summary>
    ''' <remarks>
    ''' This method returns immediately if the hardware is capable of back-to-back moves,
    ''' i.e. dual-axis moves. For hardware not having the dual-axis capability,
    ''' the method returns only after the move has completed. 
    ''' <para>
    ''' <b>NOTES:</b>
    ''' <list type="bullet">
    ''' <item><description>Raises an error if <see cref="AtPark" /> is true.</description></item>
    ''' <item><description>The <see cref="IsPulseGuiding" /> property must be be True during pulse-guiding.</description></item>
    ''' <item><description>The rate of motion for movements about the right ascension axis is 
    ''' specified by the <see cref="GuideRateRightAscension" /> property. The rate of motion
    ''' for movements about the declination axis is specified by the 
    ''' <see cref="GuideRateDeclination" /> property. These two rates may be tied together
    ''' into a single rate, depending on the driver's implementation
    ''' and the capabilities of the telescope.</description></item>
    ''' </list>
    ''' </para>
    ''' </remarks>
    ''' <param name="Direction">The direction in which the guide-rate motion is to be made</param>
    ''' <param name="Duration">The duration of the guide-rate motion (milliseconds)</param>
    Sub PulseGuide(ByVal Direction As GuideDirections, ByVal Duration As Integer)

    ''' <summary>
    ''' The right ascension (hours) of the telescope's current equatorial coordinates,
    ''' in the coordinate system given by the EquatorialSystem property
    ''' </summary>
    ''' <remarks>
    ''' Reading the property will raise an error if the value is unavailable. 
    ''' </remarks>
    ReadOnly Property RightAscension() As Double

    ''' <summary>
    ''' The right ascension tracking rate offset from sidereal (seconds per sidereal second, default = 0.0)
    ''' </summary>
    ''' <remarks>
    ''' This property, together with <see cref="DeclinationRate" />, provides support for "offset tracking".
    ''' Offset tracking is used primarily for tracking objects that move relatively slowly
    ''' against the equatorial coordinate system. It also may be used by a software guiding
    ''' system that controls rates instead of using the <see cref="PulseGuide">PulseGuide</see> method.
    ''' <para>
    ''' <b>NOTES:</b>
    ''' The property value represents an offset from the currently selected <see cref="TrackingRate" />. 
    ''' <list type="bullet">
    ''' <item><description>If this property is zero, tracking will be at the selected <see cref="TrackingRate" />.</description></item>
    ''' <item><description>If <see cref="CanSetRightAscensionRate" /> is False, this property must always return 0.</description></item> 
    ''' To discover whether this feature is supported, test the <see cref="CanSetRightAscensionRate" />property. 
    ''' <item><description>The property value is in in seconds of right ascension per sidereal second.</description></item> 
    ''' <item><description>To convert a given rate in (the more common) units of sidereal seconds
    ''' per UTC (clock) second, multiply the value by 0.9972695677 
    ''' (the number of UTC seconds in a sidereal second) then set the property.
    ''' Please note that these units were chosen for the Telescope V1 standard,
    ''' and in retrospect, this was an unfortunate choice.
    ''' However, to maintain backwards compatibility, the units cannot be changed.
    ''' A simple multiplication is all that's needed, as noted. 
    ''' The supported range of this property is telescope specific, however,
    ''' if this feature is supported, it can be expected that the range
    ''' is sufficient to allow correction of guiding errors
    ''' caused by moderate misalignment and periodic error. </description></item>
    ''' <item><description>If this property is non-zero when an equatorial slew is initiated,
    ''' the telescope should continue to update the slew destination coordinates 
    ''' at the given offset rate. This will allow precise slews to a fast-moving 
    ''' target with a slow-slewing telescope. When the slew completes, 
    ''' the <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" /> properties should
    ''' reflect the final (adjusted) destination. This is not a required
    ''' feature of this specification, however it is desirable. </description></item>
    ''' <item><description>Use the <see cref="Tracking" /> property to enable and disable sidereal tracking (if supported). </description></item>
    ''' </list>
    ''' </para>
    ''' </remarks>
    Property RightAscensionRate() As Double

    ''' <summary>
    ''' Sets the telescope's park position to be its current position.
    ''' </summary>
    Sub SetPark()

    ''' <summary>
    ''' Indicates which side of the pier a German equatorial mount is currently on
    ''' </summary>
    ''' <remarks>
    ''' It is allowed (though not required) that this property may be written to
    ''' force the mount to flip. Doing so, however, may change the right 
    ''' ascension of the telescope. During flipping,
    ''' Telescope.Slewing must return True. 
    ''' If the telescope is not a German equatorial mount (<see cref="AlignmentMode" /> is not <see cref="AlignmentModes.algGermanPolar" />), this 
    ''' method will raise an error. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    Property SideOfPier() As PierSide

    ''' <summary>
    ''' The local apparent sidereal time from the telescope's internal clock (hours, sidereal)
    ''' </summary>
    ''' <remarks>
    ''' It is required for a driver to calculate this from the system clock if the telescope 
    ''' has no accessible source of sidereal time. Local Apparent Sidereal Time is the sidereal 
    ''' time used for pointing telescopes, and thus must be calculated from the Greenwich Mean
    ''' Sidereal time, longitude, nutation in longitude and true ecliptic obliquity. 
    ''' </remarks>
    ReadOnly Property SiderealTime() As Double

    ''' <summary>
    ''' The elevation above mean sea level (meters) of the site at which the telescope is located
    ''' </summary>
    ''' <remarks>
    ''' Setting this property will raise an error if the given value is outside the range -300 through +10000 metres.
    ''' Reading the property will raise an error if the value has never been set or is otherwise unavailable. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    Property SiteElevation() As Double

    ''' <summary>
    ''' The geodetic(map) latitude (degrees, positive North, WGS84) of the site at which the telescope is located.
    ''' </summary>
    ''' <remarks>
    ''' Setting this property will raise an error if the given value is outside the range -90 to +90 degrees.
    ''' Reading the property will raise an error if the value has never been set or is otherwise unavailable. 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    Property SiteLatitude() As Double

    ''' <summary>
    ''' The longitude (degrees, positive East, WGS84) of the site at which the telescope is located.
    ''' </summary>
    ''' <remarks>
    ''' Setting this property will raise an error if the given value is outside the range -180 to +180 degrees.
    ''' Reading the property will raise an error if the value has never been set or is otherwise unavailable.
    ''' Note that West is negative! 
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    Property SiteLongitude() As Double


    ''' <summary>
    ''' True if telescope is currently moving in response to one of the
    ''' Slew methods or the <see cref="MoveAxis" /> method, False at all other times.
    ''' </summary>
    ''' <remarks>
    ''' Reading the property will raise an error if the value is unavailable.
    ''' If the telescope is not capable of asynchronous slewing,
    ''' this property will always be False. 
    ''' The definition of "slewing" excludes motion caused by sidereal tracking,
    ''' <see cref="PulseGuide">PulseGuide</see>, <see cref="RightAscensionRate" />, and <see cref="DeclinationRate" />.
    ''' It reflects only motion caused by one of the Slew commands, 
    ''' flipping caused by changing the <see cref="SideOfPier" /> property, or <see cref="MoveAxis" />. 
    ''' </remarks>
    ReadOnly Property Slewing() As Boolean

    ''' <summary>
    ''' Specifies a post-slew settling time (sec.).
    ''' </summary>
    ''' <remarks>
    ''' Adds additional time to slew operations. Slewing methods will not return, 
    ''' and the <see cref="Slewing" /> property will not become False, until the slew completes and the SlewSettleTime has elapsed.
    ''' This feature (if supported) may be used with mounts that require extra settling time after a slew. 
    ''' </remarks>
    Property SlewSettleTime() As Short

    ''' <summary>
    ''' Move the telescope to the given local horizontal coordinates, return when slew is complete
    ''' </summary>
    ''' <remarks>
    ''' This Method must be implemented if <see cref="CanSlewAltAz" /> returns True.
    ''' Raises an error if the slew fails. 
    ''' The slew may fail if the target coordinates are beyond limits imposed within the driver component.
    ''' Such limits include mechanical constraints imposed by the mount or attached instruments,
    ''' building or dome enclosure restrictions, etc.
    ''' <para>
    ''' The <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" /> properties are not changed by this method. 
    ''' Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is True. 
    ''' This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ''' <param name="Azimuth">Target azimuth (degrees, North-referenced, positive East/clockwise).</param>
    ''' <param name="Altitude">Target altitude (degrees, positive up)</param>
    Sub SlewToAltAz(ByVal Azimuth As Double, ByVal Altitude As Double)

    ''' <summary>
    ''' This Method must be implemented if <see cref="CanSlewAltAzAsync" /> returns True.
    ''' </summary>
    ''' <remarks>
    ''' This method should only be implemented if the properties <see cref="Altitude" />, <see cref="Azimuth" />,
    ''' <see cref="RightAscension" />, <see cref="Declination" /> and <see cref="Slewing" /> can be read while the scope is slewing.
    ''' Raises an error if starting the slew fails. Returns immediately after starting the slew.
    ''' The client may monitor the progress of the slew by reading the <see cref="Azimuth" />, <see cref="Altitude" />,
    ''' and <see cref="Slewing" /> properties during the slew. When the slew completes, Slewing becomes False. 
    ''' The slew may fail if the target coordinates are beyond limits imposed within the driver component.
    ''' Such limits include mechanical constraints imposed by the mount or attached instruments,
    ''' building or dome enclosure restrictions, etc. 
    ''' The <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" /> properties are not changed by this method. 
    ''' <para>
    ''' Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is True.</para>
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ''' <param name="Azimuth">Azimuth to which to move</param>
    ''' <param name="Altitude">Altitude to which to move to</param>
    Sub SlewToAltAzAsync(ByVal Azimuth As Double, ByVal Altitude As Double)

    ''' <summary>
    ''' Move the telescope to the given equatorial coordinates, return when slew is complete
    ''' </summary>
    ''' <remarks>
    ''' This Method must be implemented if <see cref="CanSlew" /> returns True. Raises an error if the slew fails. 
    ''' The slew may fail if the target coordinates are beyond limits imposed within the driver component.
    ''' Such limits include mechanical constraints imposed by the mount or attached instruments,
    ''' building or dome enclosure restrictions, etc. The target coordinates are copied to
    ''' <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" /> whether or not the slew succeeds. 
    ''' <para>Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is False.</para>
    ''' </remarks>
    ''' <param name="RightAscension">The destination right ascension (hours). Copied to <see cref="TargetRightAscension" />.</param>
    ''' <param name="Declination">The destination declination (degrees, positive North). Copied to <see cref="TargetDeclination" />.</param>
    Sub SlewToCoordinates(ByVal RightAscension As Double, ByVal Declination As Double)

    ''' <summary>
    ''' Move the telescope to the given equatorial coordinates, return immediately after starting the slew.
    ''' </summary>
    ''' <remarks>
    ''' This method must be implemented if <see cref="CanSlewAsync" /> returns True. Raises an error if starting the slew failed. 
    ''' Returns immediately after starting the slew. The client may monitor the progress of the slew by reading
    ''' the <see cref="RightAscension" />, <see cref="Declination" />, and <see cref="Slewing" /> properties during the slew. When the slew completes,
    ''' <see cref="Slewing" /> becomes False. The slew may fail to start if the target coordinates are beyond limits
    ''' imposed within the driver component. Such limits include mechanical constraints imposed
    ''' by the mount or attached instruments, building or dome enclosure restrictions, etc. 
    ''' <para>The target coordinates are copied to <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" />
    ''' whether or not the slew succeeds. 
    ''' Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is False.</para>
    ''' </remarks>
    ''' <param name="RightAscension">The destination right ascension (hours). Copied to <see cref="TargetRightAscension" />.</param>
    ''' <param name="Declination">The destination declination (degrees, positive North). Copied to <see cref="TargetDeclination" />.</param>
    Sub SlewToCoordinatesAsync(ByVal RightAscension As Double, ByVal Declination As Double)

    ''' <summary>
    ''' Move the telescope to the <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" /> coordinates, return when slew complete.
    ''' </summary>
    ''' <remarks>
    ''' This Method must be implemented if <see cref="CanSlew" /> returns True. Raises an error if the slew fails. 
    ''' The slew may fail if the target coordinates are beyond limits imposed within the driver component.
    ''' Such limits include mechanical constraints imposed by the mount or attached
    ''' instruments, building or dome enclosure restrictions, etc. 
    ''' Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is False. 
    ''' </remarks>
    Sub SlewToTarget()

    ''' <summary>
    ''' Move the telescope to the <see cref="TargetRightAscension" /> and <see cref="TargetDeclination" />  coordinates,
    ''' returns immediately after starting the slew.
    ''' </summary>
    ''' <remarks>
    ''' This Method must be implemented if  <see cref="CanSlewAsync" /> returns True.
    ''' Raises an error if starting the slew failed. 
    ''' Returns immediately after starting the slew. The client may
    ''' monitor the progress of the slew by reading the RightAscension, Declination,
    ''' and Slewing properties during the slew. When the slew completes,  <see cref="Slewing" /> becomes False. 
    ''' The slew may fail to start if the target coordinates are beyond limits imposed within 
    ''' the driver component. Such limits include mechanical constraints imposed by the mount
    ''' or attached instruments, building or dome enclosure restrictions, etc. 
    ''' Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is False. 
    ''' </remarks>
    Sub SlewToTargetAsync()

    ''' <summary>
    ''' Matches the scope's local horizontal coordinates to the given local horizontal coordinates.
    ''' </summary>
    ''' <remarks>
    ''' This must be implemented if the <see cref="CanSyncAltAz" /> property is True. Raises an error if matching fails. 
    ''' <para>Raises an error if <see cref="AtPark" /> is True, or if <see cref="Tracking" /> is True.</para>
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ''' <param name="Azimuth">Target azimuth (degrees, North-referenced, positive East/clockwise)</param>
    ''' <param name="Altitude">Target altitude (degrees, positive up)</param>
    Sub SyncToAltAz(ByVal Azimuth As Double, ByVal Altitude As Double)

    ''' <summary>
    ''' Matches the scope's equatorial coordinates to the given equatorial coordinates.
    ''' </summary>
    ''' <param name="RightAscension">The corrected right ascension (hours). Copied to the <see cref="TargetRightAscension" /> property.</param>
    ''' <param name="Declination">The corrected declination (degrees, positive North). Copied to the <see cref="TargetDeclination" /> property.</param>
    Sub SyncToCoordinates(ByVal RightAscension As Double, ByVal Declination As Double)

    ''' <summary>
    ''' Matches the scope's equatorial coordinates to the given equatorial coordinates.
    ''' </summary>
    ''' <remarks>
    ''' This must be implemented if the <see cref="CanSync" /> property is True. Raises an error if matching fails. 
    ''' Raises an error if <see cref="AtPark" /> AtPark is True, or if <see cref="Tracking" /> is False. 
    ''' </remarks>
    Sub SyncToTarget()

    ''' <summary>
    ''' The declination (degrees, positive North) for the target of an equatorial slew or sync operation
    ''' </summary>
    ''' <remarks>
    ''' Setting this property will raise an error if the given value is outside the range -90 to +90 degrees.
    ''' Reading the property will raise an error if the value has never been set or is otherwise unavailable. 
    ''' </remarks>
    Property TargetDeclination() As Double

    ''' <summary>
    ''' The right ascension (hours) for the target of an equatorial slew or sync operation
    ''' </summary>
    ''' <remarks>
    ''' Setting this property will raise an error if the given value is outside the range 0 to 24 hours.
    ''' Reading the property will raise an error if the value has never been set or is otherwise unavailable. 
    ''' </remarks>
    Property TargetRightAscension() As Double

    ''' <summary>
    ''' The state of the telescope's sidereal tracking drive.
    ''' </summary>
    ''' <remarks>
    ''' Changing the value of this property will turn the sidereal drive on and off.
    ''' However, some telescopes may not support changing the value of this property
    ''' and thus may not support turning tracking on and off.
    ''' See the <see cref="CanSetTracking" /> property. 
    ''' </remarks>
    Property Tracking() As Boolean

    ''' <summary>
    ''' The current tracking rate of the telescope's sidereal drive
    ''' </summary>
    ''' <remarks>
    ''' Supported rates (one of the <see cref="DriveRates" />  values) are contained within the <see cref="TrackingRates" /> collection.
    ''' Values assigned to TrackingRate must be one of these supported rates. 
    ''' If an unsupported value is assigned to this property, it will raise an error. 
    ''' The currently selected tracking rate be further adjusted via the <see cref="RightAscensionRate" /> 
    ''' and <see cref="DeclinationRate" /> properties. These rate offsets are applied to the currently 
    ''' selected tracking rate. Mounts must start up with a known or default tracking rate,
    ''' and this property must return that known/default tracking rate until changed.
    ''' <para>If the mount's current tracking rate cannot be determined (for example, 
    ''' it is a write-only property of the mount's protocol), 
    ''' it is permitted for the driver to force and report a default rate on connect.
    ''' In this case, the preferred default is Sidereal rate.</para>
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    Property TrackingRate() As DriveRates

    ''' <summary>
    ''' Returns a collection of supported <see cref="DriveRates" /> values that describe the permissible
    ''' values of the <see cref="TrackingRate" /> property for this telescope type.
    ''' </summary>
    ''' <remarks>
    ''' At a minimum, this must contain an item for <see cref="DriveRates.driveSidereal" />.
    ''' <para>This is only available for telescope InterfaceVersions 2 and 3</para>
    ''' </remarks>
    ReadOnly Property TrackingRates() As ITrackingRates

    ''' <summary>
    ''' Takes telescope out of the Parked state.
    ''' </summary>
    ''' <remarks>
    ''' The state of <see cref="Tracking" /> after unparking is undetermined. 
    ''' Valid only after <see cref="Park" />.
    ''' Applications must check and change Tracking as needed after unparking. 
    ''' Raises an error if unparking fails. Calling this with <see cref="AtPark" /> = False does nothing (harmless) 
    ''' </remarks>
    Sub Unpark()

    ''' <summary>
    ''' The UTC date/time of the telescope's internal clock
    ''' </summary>
    ''' <remarks>
    ''' The driver must calculate this from the system clock if the telescope has no accessible
    ''' source of UTC time. In this case, the property must not be writeable 
    ''' (this would change the system clock!) and will instead raise an error.
    ''' However, it is permitted to change the telescope's internal UTC clock 
    ''' if it is being used for this property. This allows clients to adjust 
    ''' the telescope's UTC clock as needed for accuracy. Reading the property
    ''' will raise an error if the value has never been set or is otherwise unavailable. 
    ''' </remarks>
    Property UTCDate() As DateTime
#End Region

End Interface