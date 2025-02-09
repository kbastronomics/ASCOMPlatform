;
; Script generated by the ASCOM Driver Installer Script Generator 1.2.0.0
; Generated by Bob Denny on 10/8/2008 (UTC)
;
[Setup]
AppName=ASCOM ACLDome Dome Driver
AppVerName=ASCOM ACLDome Dome Driver 5.0.2
AppVersion=5.0.2
AppPublisher=Jon Brewster
AppSupportURL=https://ascomtalk.groups.io/g/Help/topics
AppUpdatesURL=https://ascom-standards.org/
MinVersion=0,5.0.2195sp4
DefaultDirName="{cf}\ASCOM\Dome"
DisableDirPage=yes
DisableProgramGroupPage=yes
OutputDir="."
OutputBaseFilename="ACLDome Setup"
Compression=lzma
SolidCompression=yes
; Put there by Platform if Driver Installer Support selected
WizardImageFile="C:\Program Files\ASCOM\InstallGen\Resources\WizardImage.bmp"
LicenseFile="C:\Program Files\ASCOM\InstallGen\Resources\CreativeCommons.txt"
; {cf}\ASCOM\Uninstall\Dome folder created by Platform, always
UninstallFilesDir="{cf}\ASCOM\Uninstall\Dome\ACLDome"

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Dirs]
Name: "{cf}\ASCOM\Uninstall\Dome\ACLDome"
; TODO: Add subfolders below {app} as needed (e.g. Name: "{app}\MyFolder")

;  Add an option to install the source files
[Tasks]
Name: source; Description: Install the Source files; Flags: unchecked

[Files]
; regserver flag only if native COM, not .NET
Source: "D:\Astro Projects\ASCOM Platform 5 Drivers\ACL Dome Driver\ACL Dome Driver.dll"; DestDir: "{app}" ;AfterInstall: RegASCOM(); Flags: regserver
; Optional source files (COM and .NET aware)
Source: "D:\Astro Projects\ASCOM Platform 5 Drivers\ACL Dome Driver\*"; Excludes: *.zip,*.exe,*.dll, \bin\*, \obj\*; DestDir: "{app}\Source\ACLDome Driver"; Tasks: source; Flags: recursesubdirs
; TODO: Add other files needed by your driver here (add subfolders above)

[CODE]
//
// Before the installer UI appears, verify that the (prerequisite)
// ASCOM Platform 5.x is installed, including both Helper components.
// Helper is required for all typpes (COM and .NET)!
//
function InitializeSetup(): Boolean;
var
   H : Variant;
   H2 : Variant;
begin
   Result := FALSE;  // Assume failure
   try               // Will catch all errors including missing reg data
      H := CreateOLEObject('DriverHelper.Util');  // Assure both are available
      H2 := CreateOleObject('DriverHelper2.Util');
      if ((H2.PlatformVersion >= 5.0) and (H2.PlatformVersion < 6.0)) then
         Result := TRUE;
   except
   end;
   if(not Result) then
      MsgBox('The ASCOM Platform 5 is required for this driver.', mbInformation, MB_OK);
end;

//
// Register and unregister the driver with the Chooser
// We already know that the Helper is available
//
procedure RegASCOM();
var
   Helper: Variant;
begin
   Helper := CreateOleObject('DriverHelper.Profile');
   Helper.DeviceType := 'Dome';
   Helper.Register('ACLDome.Dome', 'ACL Dome Controllers');
end;

procedure CurUninstallStepChanged(CurUninstallStep: TUninstallStep);
var
   Helper: Variant;
begin
   if CurUninstallStep = usUninstall then
   begin
     Helper := CreateOleObject('DriverHelper.Profile');
     Helper.DeviceType := 'Dome';
     Helper.Unregister('ACLDome.Dome');
  end;
end;
