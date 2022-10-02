using System.IO;

namespace program_inst_manager
{
	/// <summary>
	/// Stores information for adding or removing program installation info from the Registry.
	/// </summary>
	public struct ProgramInstallInfo
	{
		/// <summary>
		/// The icon displayed in the program list in Windows Settings
		/// </summary>
		public string DisplayIcon;

		/// <summary>
		/// The name displayed in the program list in Windows Settings
		/// </summary>
		public string DisplayName;

		/// <summary>
		/// The version displayed in the program list in Windows Settings
		/// </summary>
		public string DisplayVersion;

		/// <summary>
		/// The directory of the program installed on the device
		/// </summary>
		public string InstallLocation;

		/// <summary>
		/// The publisher name shown in the program list in Windows Settings
		/// </summary>
		public string Publisher;

		/// <summary>
		/// Indicates whether or not the installed software is a system component
		/// </summary>
		public bool SystemComponent;

		/// <summary>
		/// The file path to the executable that uninstalls the program
		/// </summary>
		public string UninstallString;

		/// <summary>
		/// The url to the about website of the software product
		/// </summary>
		public string URLInfoAbout;

		/// <summary>
		/// Indicates whether or not the program's installation can be modified
		/// </summary>
		public bool CanModify;

		/// <summary>
		/// Indiciates whether or not the program's installation can be repaired
		/// </summary>
		public bool CanRepair;

		/// <summary>
		/// The file path to the executable that modifies (modify/repair) the program's installation
		/// </summary>
		public string ModifyPath;

		internal ProgramInstallInfo(string DisplayIcon, string DisplayName, string DisplayVersion,
			string InstallLocation, string Publisher, bool SystemComponent,
			string UninstallString, string URLInfoAbout, bool CanModify,
			bool CanRepair, string ModifyPath)
		{
			this.DisplayIcon = DisplayIcon;
			this.DisplayName = DisplayName;
			this.DisplayVersion = DisplayVersion;
			this.InstallLocation = InstallLocation;
			this.Publisher = Publisher;
			this.SystemComponent = SystemComponent;
			this.UninstallString = UninstallString;
			this.URLInfoAbout = URLInfoAbout;
			this.CanModify = CanModify;
			this.CanRepair = CanRepair;
			this.ModifyPath = ModifyPath;
		}

		public static ProgramInstallInfo CreateInstallInfo(string Icon, string Name, string Version, string ProgramPath, string ProgramUninstaller, string Publisher, bool SysComp, string AboutURL, bool Modify, bool Repair, string ModifyPath)
		{
			return new ProgramInstallInfo(Icon, Name, Version,
				Path.GetDirectoryName(ProgramPath), Publisher, SysComp,
				ProgramUninstaller, AboutURL, Modify,
				Repair, ModifyPath);
		}
	}
}
