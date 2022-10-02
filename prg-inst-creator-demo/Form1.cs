using Microsoft.Win32;
using program_inst_manager;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace prg_inst_creator_demo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);

				if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
				{
					MessageBox.Show("Administrator rights are required to perform installation demo.", "Admin rights required",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					Close();
				}
			}

			string[] args = Environment.GetCommandLineArgs();
			args = args.Where(arg => arg != args[0]).ToArray();

			if (args.Length == 1 && args[0] == "/uninstall")
				UninstallProgram(this, null);

			if (InstallationManager.CheckForInstallInfo(installInfo))
			{
				btnAddProgram.Enabled = false;
				btnRemoveProgram.Enabled = true;
			}
		}

		private ProgramInstallInfo installInfo = new ProgramInstallInfo
		{
			DisplayIcon = $"{Application.StartupPath}\\prg-inst-creator-demo.exe",
			DisplayName = "Form1_InstallDemo",
			DisplayVersion = "1.0.0",
			InstallLocation = Application.StartupPath,
			Publisher = "Form1_InstallDemo",
			SystemComponent = false,
			UninstallString = $"{Application.StartupPath}\\prg-inst-creator-demo.exe /uninstall",
			URLInfoAbout = "https://github.com/Lexz-08/program-inst-manager",
			CanModify = false,
			CanRepair = false,
			ModifyPath = ""
		};

		private void LinkHover(object sender, EventArgs e)
		{
			lblGithubLink.ForeColor = Color.Blue;
		}

		private void LinkLeave(object sender, EventArgs e)
		{
			lblGithubLink.ForeColor = SystemColors.ControlText;
		}

		private void LinkClick(object sender, EventArgs e)
		{
			Process.Start(lblGithubLink.Text);
		}

		private void InstallProgram(object sender, EventArgs e)
		{
			InstallationManager.AddInstallInfo(installInfo);
			btnAddProgram.Enabled = false;
			btnRemoveProgram.Enabled = true;
		}

		private void UninstallProgram(object sender, EventArgs e)
		{
			InstallationManager.RemoveInstallInfo(installInfo);
			btnAddProgram.Enabled = true;
			btnRemoveProgram.Enabled = false;
		}
	}
}
