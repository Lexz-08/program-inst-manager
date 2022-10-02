using Microsoft.Win32;
using System;
using System.Linq;

namespace program_inst_manager
{
	public static class InstallationManager
	{
		/// <summary>
		/// Adds the provided program installation info to your device registry
		/// </summary>
		/// <param name="InstallInfo">The program installation info to add</param>
		public static void AddInstallInfo(ProgramInstallInfo InstallInfo)
		{
			RegistryKey rootKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true);
			RegistryKey installKey = rootKey.CreateSubKey(InstallInfo.DisplayName);

			installKey.SetValue("DisplayIcon", InstallInfo.DisplayIcon, RegistryValueKind.String);
			installKey.SetValue("DisplayName", InstallInfo.DisplayName, RegistryValueKind.String);
			installKey.SetValue("DisplayVersion", InstallInfo.DisplayVersion, RegistryValueKind.String);
			installKey.SetValue("InstallLocation", InstallInfo.InstallLocation, RegistryValueKind.String);
			installKey.SetValue("Publisher", InstallInfo.Publisher, RegistryValueKind.String);
			installKey.SetValue("SystemComponent", InstallInfo.SystemComponent ? 1 : 0, RegistryValueKind.DWord);
			installKey.SetValue("UninstallString", InstallInfo.UninstallString, RegistryValueKind.String);
			installKey.SetValue("URLInfoAbout", InstallInfo.URLInfoAbout, RegistryValueKind.String);
			installKey.SetValue("CanModify", InstallInfo.CanModify ? 1 : 0, RegistryValueKind.DWord);
			installKey.SetValue("CanRepair", InstallInfo.CanRepair ? 1 : 0, RegistryValueKind.DWord);
			installKey.SetValue("ModifyPath", InstallInfo.ModifyPath, RegistryValueKind.String);

			installKey.Close();
			rootKey.Close();
		}

		/// <summary>
		/// Removes the specified program installation info from your device registry
		/// </summary>
		/// <param name="InstallInfo">Used to identify the program installation info of which to be removed from your device registry</param>
		public static void RemoveInstallInfo(ProgramInstallInfo InstallInfo)
		{
			RegistryKey rootKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true);
			RegistryKey installKey = rootKey.OpenSubKey(InstallInfo.DisplayName);

			if (installKey.GetValue("DisplayIcon").ToString() == InstallInfo.DisplayIcon &&
				installKey.GetValue("DisplayName").ToString() == InstallInfo.DisplayName &&
				installKey.GetValue("DisplayVersion").ToString() == InstallInfo.DisplayVersion &&
				installKey.GetValue("InstallLocation").ToString() == InstallInfo.InstallLocation &&
				installKey.GetValue("Publisher").ToString() == InstallInfo.Publisher &&
				(int)installKey.GetValue("SystemComponent") == (InstallInfo.SystemComponent ? 1 : 0) &&
				installKey.GetValue("UninstallString").ToString() == InstallInfo.UninstallString &&
				installKey.GetValue("URLInfoAbout").ToString() == InstallInfo.URLInfoAbout &&
				(int)installKey.GetValue("CanModify") == (InstallInfo.CanModify ? 1 : 0) &&
				(int)installKey.GetValue("CanRepair") == (InstallInfo.CanRepair ? 1 : 0) &&
				installKey.GetValue("ModifyPath").ToString() == InstallInfo.ModifyPath)
				rootKey.DeleteSubKey(InstallInfo.DisplayName, true);

			rootKey.Close();
		}

		/// <summary>
		/// Checks the device's registry to see if the specified program's installation info was added
		/// </summary>
		/// <param name="InstallInfo">The program's installation info to check for</param>
		/// <returns><see langword="true"/> if the info is found, <see langword="false"/> if otherwise</returns>
		public static bool CheckForInstallInfo(ProgramInstallInfo InstallInfo)
		{
			RegistryKey rootKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true);
			RegistryKey installKey = rootKey.OpenSubKey(InstallInfo.DisplayName);
			bool result = false;

			if (rootKey == null || installKey == null) result = false;

			if (installKey != null &&
				installKey.GetValue("DisplayIcon").ToString() == InstallInfo.DisplayIcon &&
				installKey.GetValue("DisplayName").ToString() == InstallInfo.DisplayName &&
				installKey.GetValue("DisplayVersion").ToString() == InstallInfo.DisplayVersion &&
				installKey.GetValue("InstallLocation").ToString() == InstallInfo.InstallLocation &&
				installKey.GetValue("Publisher").ToString() == InstallInfo.Publisher &&
				(int)installKey.GetValue("SystemComponent") == (InstallInfo.SystemComponent ? 1 : 0) &&
				installKey.GetValue("UninstallString").ToString() == InstallInfo.UninstallString &&
				installKey.GetValue("URLInfoAbout").ToString() == InstallInfo.URLInfoAbout &&
				(int)installKey.GetValue("CanModify") == (InstallInfo.CanModify ? 1 : 0) &&
				(int)installKey.GetValue("CanRepair") == (InstallInfo.CanRepair ? 1 : 0) &&
				installKey.GetValue("ModifyPath").ToString() == InstallInfo.ModifyPath)
				result = true;

			installKey?.Close();
			rootKey.Close();

			return result;
		}
	}
}
