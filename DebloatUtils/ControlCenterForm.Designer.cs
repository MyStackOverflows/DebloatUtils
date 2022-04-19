namespace DebloatUtils
{
    partial class ControlCenterForm
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
            this.CurrentDownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentDownloadStatsLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CleanUpButton = new System.Windows.Forms.Button();
            this.WindowsToolsButton = new System.Windows.Forms.Button();
            this.WinverButton = new System.Windows.Forms.Button();
            this.ControlPanelButton = new System.Windows.Forms.Button();
            this.CmdButton = new System.Windows.Forms.Button();
            this.DevicesAndPrintersButton = new System.Windows.Forms.Button();
            this.ProgramsAndFeaturesButton = new System.Windows.Forms.Button();
            this.DeviceManagerButton = new System.Windows.Forms.Button();
            this.ComputerManagementButton = new System.Windows.Forms.Button();
            this.InstallCheckBox = new System.Windows.Forms.CheckBox();
            this.PowerShellButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenDLFolderButton = new System.Windows.Forms.Button();
            this.RunCheckBox = new System.Windows.Forms.CheckBox();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.FilesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SendBugReportButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.AutoOOSUButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentDownloadProgressBar
            // 
            this.CurrentDownloadProgressBar.Location = new System.Drawing.Point(6, 141);
            this.CurrentDownloadProgressBar.Name = "CurrentDownloadProgressBar";
            this.CurrentDownloadProgressBar.Size = new System.Drawing.Size(378, 23);
            this.CurrentDownloadProgressBar.TabIndex = 4;
            // 
            // CurrentDownloadStatsLabel
            // 
            this.CurrentDownloadStatsLabel.AutoSize = true;
            this.CurrentDownloadStatsLabel.Location = new System.Drawing.Point(6, 125);
            this.CurrentDownloadStatsLabel.Name = "CurrentDownloadStatsLabel";
            this.CurrentDownloadStatsLabel.Size = new System.Drawing.Size(128, 13);
            this.CurrentDownloadStatsLabel.TabIndex = 5;
            this.CurrentDownloadStatsLabel.Text = "0MB / 0MB; 0% complete";
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(309, 170);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // CleanUpButton
            // 
            this.CleanUpButton.Location = new System.Drawing.Point(6, 170);
            this.CleanUpButton.Name = "CleanUpButton";
            this.CleanUpButton.Size = new System.Drawing.Size(140, 23);
            this.CleanUpButton.TabIndex = 7;
            this.CleanUpButton.Text = "Clean up downloaded files";
            this.CleanUpButton.UseVisualStyleBackColor = true;
            this.CleanUpButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // WindowsToolsButton
            // 
            this.WindowsToolsButton.Location = new System.Drawing.Point(6, 6);
            this.WindowsToolsButton.Name = "WindowsToolsButton";
            this.WindowsToolsButton.Size = new System.Drawing.Size(90, 40);
            this.WindowsToolsButton.TabIndex = 8;
            this.WindowsToolsButton.Text = "Admin Tools";
            this.WindowsToolsButton.UseVisualStyleBackColor = true;
            this.WindowsToolsButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // WinverButton
            // 
            this.WinverButton.Location = new System.Drawing.Point(6, 52);
            this.WinverButton.Name = "WinverButton";
            this.WinverButton.Size = new System.Drawing.Size(90, 40);
            this.WinverButton.TabIndex = 9;
            this.WinverButton.Text = "Windows Version";
            this.WinverButton.UseVisualStyleBackColor = true;
            this.WinverButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // ControlPanelButton
            // 
            this.ControlPanelButton.Location = new System.Drawing.Point(102, 52);
            this.ControlPanelButton.Name = "ControlPanelButton";
            this.ControlPanelButton.Size = new System.Drawing.Size(90, 40);
            this.ControlPanelButton.TabIndex = 10;
            this.ControlPanelButton.Text = "Control Panel";
            this.ControlPanelButton.UseVisualStyleBackColor = true;
            this.ControlPanelButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // CmdButton
            // 
            this.CmdButton.Location = new System.Drawing.Point(198, 6);
            this.CmdButton.Name = "CmdButton";
            this.CmdButton.Size = new System.Drawing.Size(90, 40);
            this.CmdButton.TabIndex = 11;
            this.CmdButton.Text = "Admin Cmd";
            this.CmdButton.UseVisualStyleBackColor = true;
            this.CmdButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // DevicesAndPrintersButton
            // 
            this.DevicesAndPrintersButton.Location = new System.Drawing.Point(102, 98);
            this.DevicesAndPrintersButton.Name = "DevicesAndPrintersButton";
            this.DevicesAndPrintersButton.Size = new System.Drawing.Size(90, 40);
            this.DevicesAndPrintersButton.TabIndex = 12;
            this.DevicesAndPrintersButton.Text = "Devices and Printers";
            this.DevicesAndPrintersButton.UseVisualStyleBackColor = true;
            this.DevicesAndPrintersButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // ProgramsAndFeaturesButton
            // 
            this.ProgramsAndFeaturesButton.Location = new System.Drawing.Point(198, 98);
            this.ProgramsAndFeaturesButton.Name = "ProgramsAndFeaturesButton";
            this.ProgramsAndFeaturesButton.Size = new System.Drawing.Size(90, 40);
            this.ProgramsAndFeaturesButton.TabIndex = 13;
            this.ProgramsAndFeaturesButton.Text = "Uninstall a program";
            this.ProgramsAndFeaturesButton.UseVisualStyleBackColor = true;
            this.ProgramsAndFeaturesButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // DeviceManagerButton
            // 
            this.DeviceManagerButton.Location = new System.Drawing.Point(6, 98);
            this.DeviceManagerButton.Name = "DeviceManagerButton";
            this.DeviceManagerButton.Size = new System.Drawing.Size(90, 40);
            this.DeviceManagerButton.TabIndex = 14;
            this.DeviceManagerButton.Text = "Device Manager";
            this.DeviceManagerButton.UseVisualStyleBackColor = true;
            this.DeviceManagerButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // ComputerManagementButton
            // 
            this.ComputerManagementButton.Location = new System.Drawing.Point(198, 52);
            this.ComputerManagementButton.Name = "ComputerManagementButton";
            this.ComputerManagementButton.Size = new System.Drawing.Size(90, 40);
            this.ComputerManagementButton.TabIndex = 15;
            this.ComputerManagementButton.Text = "Computer Management";
            this.ComputerManagementButton.UseVisualStyleBackColor = true;
            this.ComputerManagementButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // InstallCheckBox
            // 
            this.InstallCheckBox.AutoSize = true;
            this.InstallCheckBox.Checked = true;
            this.InstallCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InstallCheckBox.Location = new System.Drawing.Point(162, 170);
            this.InstallCheckBox.Name = "InstallCheckBox";
            this.InstallCheckBox.Size = new System.Drawing.Size(126, 17);
            this.InstallCheckBox.TabIndex = 16;
            this.InstallCheckBox.Text = "Install after download";
            this.InstallCheckBox.UseVisualStyleBackColor = true;
            this.InstallCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // PowerShellButton
            // 
            this.PowerShellButton.Location = new System.Drawing.Point(102, 6);
            this.PowerShellButton.Name = "PowerShellButton";
            this.PowerShellButton.Size = new System.Drawing.Size(90, 40);
            this.PowerShellButton.TabIndex = 20;
            this.PowerShellButton.Text = "Admin PowerShell";
            this.PowerShellButton.UseVisualStyleBackColor = true;
            this.PowerShellButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 234);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenDLFolderButton);
            this.tabPage1.Controls.Add(this.RunCheckBox);
            this.tabPage1.Controls.Add(this.UninstallButton);
            this.tabPage1.Controls.Add(this.DownloadButton);
            this.tabPage1.Controls.Add(this.FilesCheckedListBox);
            this.tabPage1.Controls.Add(this.CurrentDownloadStatsLabel);
            this.tabPage1.Controls.Add(this.CleanUpButton);
            this.tabPage1.Controls.Add(this.CancelButton);
            this.tabPage1.Controls.Add(this.InstallCheckBox);
            this.tabPage1.Controls.Add(this.CurrentDownloadProgressBar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download, Install, & Uninstall";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenDLFolderButton
            // 
            this.OpenDLFolderButton.Location = new System.Drawing.Point(6, 83);
            this.OpenDLFolderButton.Name = "OpenDLFolderButton";
            this.OpenDLFolderButton.Size = new System.Drawing.Size(150, 32);
            this.OpenDLFolderButton.TabIndex = 21;
            this.OpenDLFolderButton.Text = "Open download folder";
            this.OpenDLFolderButton.UseVisualStyleBackColor = true;
            this.OpenDLFolderButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // RunCheckBox
            // 
            this.RunCheckBox.AutoSize = true;
            this.RunCheckBox.Checked = true;
            this.RunCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunCheckBox.Location = new System.Drawing.Point(162, 188);
            this.RunCheckBox.Name = "RunCheckBox";
            this.RunCheckBox.Size = new System.Drawing.Size(99, 17);
            this.RunCheckBox.TabIndex = 20;
            this.RunCheckBox.Text = "Run after install";
            this.RunCheckBox.UseVisualStyleBackColor = true;
            // 
            // UninstallButton
            // 
            this.UninstallButton.Location = new System.Drawing.Point(6, 44);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(150, 33);
            this.UninstallButton.TabIndex = 19;
            this.UninstallButton.Text = "Uninstall checked items";
            this.UninstallButton.UseVisualStyleBackColor = true;
            this.UninstallButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(6, 6);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(150, 32);
            this.DownloadButton.TabIndex = 18;
            this.DownloadButton.Text = "Download checked items";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // FilesCheckedListBox
            // 
            this.FilesCheckedListBox.FormattingEnabled = true;
            this.FilesCheckedListBox.Location = new System.Drawing.Point(162, 6);
            this.FilesCheckedListBox.Name = "FilesCheckedListBox";
            this.FilesCheckedListBox.Size = new System.Drawing.Size(222, 109);
            this.FilesCheckedListBox.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WindowsToolsButton);
            this.tabPage3.Controls.Add(this.PowerShellButton);
            this.tabPage3.Controls.Add(this.ComputerManagementButton);
            this.tabPage3.Controls.Add(this.WinverButton);
            this.tabPage3.Controls.Add(this.DeviceManagerButton);
            this.tabPage3.Controls.Add(this.ControlPanelButton);
            this.tabPage3.Controls.Add(this.ProgramsAndFeaturesButton);
            this.tabPage3.Controls.Add(this.CmdButton);
            this.tabPage3.Controls.Add(this.DevicesAndPrintersButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(390, 208);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shortcuts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AutoOOSUButton);
            this.tabPage4.Controls.Add(this.SendBugReportButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(390, 208);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Other";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SendBugReportButton
            // 
            this.SendBugReportButton.Location = new System.Drawing.Point(99, 3);
            this.SendBugReportButton.Name = "SendBugReportButton";
            this.SendBugReportButton.Size = new System.Drawing.Size(90, 40);
            this.SendBugReportButton.TabIndex = 4;
            this.SendBugReportButton.Text = "Send Bug Report";
            this.SendBugReportButton.UseVisualStyleBackColor = true;
            this.SendBugReportButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 252);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(394, 93);
            this.LogTextBox.TabIndex = 22;
            // 
            // AutoOOSUButton
            // 
            this.AutoOOSUButton.Location = new System.Drawing.Point(3, 3);
            this.AutoOOSUButton.Name = "AutoOOSUButton";
            this.AutoOOSUButton.Size = new System.Drawing.Size(90, 40);
            this.AutoOOSUButton.TabIndex = 5;
            this.AutoOOSUButton.Text = "Automate OOSU10";
            this.AutoOOSUButton.UseVisualStyleBackColor = true;
            this.AutoOOSUButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // ControlCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 357);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(434, 396);
            this.Name = "ControlCenterForm";
            this.Text = "DebloatUtils by h4ck3rm4n";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar CurrentDownloadProgressBar;
        private System.Windows.Forms.Label CurrentDownloadStatsLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CleanUpButton;
        private System.Windows.Forms.Button WindowsToolsButton;
        private System.Windows.Forms.Button WinverButton;
        private System.Windows.Forms.Button ControlPanelButton;
        private System.Windows.Forms.Button CmdButton;
        private System.Windows.Forms.Button DevicesAndPrintersButton;
        private System.Windows.Forms.Button ProgramsAndFeaturesButton;
        private System.Windows.Forms.Button DeviceManagerButton;
        private System.Windows.Forms.Button ComputerManagementButton;
        private System.Windows.Forms.CheckBox InstallCheckBox;
        private System.Windows.Forms.Button PowerShellButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox FilesCheckedListBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.CheckBox RunCheckBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button OpenDLFolderButton;
        private System.Windows.Forms.Button SendBugReportButton;
        private System.Windows.Forms.Button AutoOOSUButton;
    }
}

