# program-inst-manager
## Description
add program install info, remove it, or check for it for Windows

## How To Use
This code is made as an example ***automatically referencing `program-inst-manager.dll`***.<br/>
```csharp
// create installation info for example
var installInfo = new ProgramInstallInfo
{
    DisplayIcon = "example.ico",
    DisplayName = "Example Program",
    DisplayVersion = "1.3.2.0",
    InstallLocation = @"C:\Program Files (x86)\Example Program",
    Publisher = "Example Publisher",
    SystemComponent = false,
    UninstallString = @"C:\Program Files(x86)\Example Program\uninstall.exe",
    URLInfoAbout = "https://example.com",
    CanModify = true,
    CanRepair = true,
    ModifyPath = @"C:\Program Files (x86)\Example Program\modify.exe"
};
bool hasInstall = Installation.CheckForInstallInfo(installInfo);

// add install info to Registry if not already added
if (!hasInstall) InstallationManager.AddInstallInfo(installInfo);

// remove install info from Registry if already added
if (hasInstall) InstallationManager.RemoveInstallInfo(installInfo);
```

## Documentation
  * `ProgramInstallInfo`: Installation info for your program
  * `InstallationManager`
    * `CheckForInstallInfo`
      * Returns `true` or `false` depending on whether or not the specified program installation info was added to the Registry
    * `AddInstallInfo`
      * Adds the provided program installation info to the Registry
    * `RemoveInstallInfo`
      * Removes the specified program installation info from the Registry

## Download
[Standalone (x86/x32)](https://github.com/Lexz-08/program-inst-manager/releases/latest/download/program-inst-manager-(x86).dll)<br/>
[Standalone (x64)](https://github.com/Lexz-08/program-inst-manager/releases/latest/download/program-inst-manager-(x86).dll)
