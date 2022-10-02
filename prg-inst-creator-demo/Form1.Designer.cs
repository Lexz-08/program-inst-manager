namespace prg_inst_creator_demo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblRegistryInfo = new System.Windows.Forms.Label();
			this.btnAddProgram = new System.Windows.Forms.Button();
			this.btnRemoveProgram = new System.Windows.Forms.Button();
			this.lblGithubLink = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblRegistryInfo
			// 
			this.lblRegistryInfo.AutoSize = true;
			this.lblRegistryInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblRegistryInfo.Location = new System.Drawing.Point(12, 9);
			this.lblRegistryInfo.Name = "lblRegistryInfo";
			this.lblRegistryInfo.Size = new System.Drawing.Size(367, 165);
			this.lblRegistryInfo.TabIndex = 0;
			this.lblRegistryInfo.Text = resources.GetString("lblRegistryInfo.Text");
			// 
			// btnAddProgram
			// 
			this.btnAddProgram.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddProgram.Location = new System.Drawing.Point(469, 213);
			this.btnAddProgram.Name = "btnAddProgram";
			this.btnAddProgram.Size = new System.Drawing.Size(87, 23);
			this.btnAddProgram.TabIndex = 1;
			this.btnAddProgram.Text = "Add to Registry";
			this.btnAddProgram.UseVisualStyleBackColor = true;
			this.btnAddProgram.Click += new System.EventHandler(this.InstallProgram);
			// 
			// btnRemoveProgram
			// 
			this.btnRemoveProgram.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemoveProgram.Enabled = false;
			this.btnRemoveProgram.Location = new System.Drawing.Point(344, 213);
			this.btnRemoveProgram.Name = "btnRemoveProgram";
			this.btnRemoveProgram.Size = new System.Drawing.Size(119, 23);
			this.btnRemoveProgram.TabIndex = 2;
			this.btnRemoveProgram.Text = "Remove from Registry";
			this.btnRemoveProgram.UseVisualStyleBackColor = true;
			this.btnRemoveProgram.Click += new System.EventHandler(this.UninstallProgram);
			// 
			// lblGithubLink
			// 
			this.lblGithubLink.AutoSize = true;
			this.lblGithubLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblGithubLink.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.lblGithubLink.Location = new System.Drawing.Point(12, 217);
			this.lblGithubLink.Name = "lblGithubLink";
			this.lblGithubLink.Size = new System.Drawing.Size(281, 15);
			this.lblGithubLink.TabIndex = 3;
			this.lblGithubLink.Text = "https://github.com/Lexz-08/program-inst-manager";
			this.lblGithubLink.Click += new System.EventHandler(this.LinkClick);
			this.lblGithubLink.MouseEnter += new System.EventHandler(this.LinkHover);
			this.lblGithubLink.MouseLeave += new System.EventHandler(this.LinkLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(568, 248);
			this.Controls.Add(this.lblGithubLink);
			this.Controls.Add(this.btnRemoveProgram);
			this.Controls.Add(this.btnAddProgram);
			this.Controls.Add(this.lblRegistryInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRegistryInfo;
		private System.Windows.Forms.Button btnAddProgram;
		private System.Windows.Forms.Button btnRemoveProgram;
		private System.Windows.Forms.Label lblGithubLink;
	}
}

