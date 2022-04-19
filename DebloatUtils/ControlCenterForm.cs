using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Win32;

namespace DebloatUtils
{
    public partial class ControlCenterForm : Form
    {
        // ADD MACRIUM REFLECT
        // https://updates.macrium.com/reflect/v7/ReflectDLHF.exe <-- for macrium reflect
        #region global constants and other shenanigans
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        string workdir = "";

        List<ApplicationObject> Applications = new List<ApplicationObject>()
        {
            new ApplicationObject("CCleaner", "https://bits.avcdn.net/productfamily_CCLEANER/insttype_FREE/platform_WIN_PIR/installertype_ONLINE/build_RELEASE", "CCleanerSetup.exe", true, "/S", @"C:\Program Files\CCleaner\CCleaner64.exe", @"C:\Program Files\CCleaner\uninst.exe", "/S"),
            new ApplicationObject("Malwarebytes", "https://downloads.malwarebytes.com/file/mb-windows", "MalwarebytesSetup.exe", true, "/verysilent /nocancel /norestart /suppressmsgboxes", @"C:\Program Files\Malwarebytes\Anti-Malware\mbam.exe", @"C:\Program Files\Malwarebytes\Anti-Malware\mbuns.exe", "/verysilent /nocancel /norestart /suppressmsgboxes"),
            new ApplicationObject("ESET One Time Scan", "https://download.eset.com/com/eset/tools/online_scanner/latest/esetonlinescanner.exe", "ESETOneTimeScan.exe", false, "", "", "", ""),
            new ApplicationObject("Win10 Update Assistant", "https://go.microsoft.com/fwlink/?LinkID=799445", "Win10UpdateAssistant.exe", false, "", "", "", ""),
            new ApplicationObject("Win10 Media Creation Tool", "https://go.microsoft.com/fwlink/?LinkID=691209", "Win10MediaCreationTool.exe", false, "", "", "", ""),
            new ApplicationObject("OOSU10", "https://dl5.oo-software.com/files/ooshutup10/OOSU10.exe", "OOSU10.exe", false, "", "", "", ""),
            new ApplicationObject("Auslogics Defrag", "https://downloads.auslogics.com/en/disk-defrag/disk-defrag-setup.exe", "AuslogicsDefragSetup.exe", true, "/SP- /VERYSILENT /NORESTART", @"C:\Program Files (x86)\Auslogics\Disk Defrag\Integrator.exe", @"C:\Program Files (x86)\Auslogics\Disk Defrag\unins000.exe", "/VERYSILENT"),
            new ApplicationObject("Firefox", "https://download.mozilla.org/?product=firefox-latest-ssl&os=win64&lang=en-US", "FirefoxSetup.exe", true, "/S", @"C:\Program Files\Mozilla Firefox\firefox.exe", @"C:\Program Files\Mozilla Firefox\uninstall\helper.exe", "/S"),
            new ApplicationObject("Edge", "https://go.microsoft.com/fwlink/?linkid=2108834&Channel=Stable&language=en", "MSEdgeSetup.exe", true, "/S", @"", "", ""),
            new ApplicationObject("VLC Media Player", "https://www.videolan.org/vlc", "VLCSetup.exe", true, "/S", @"C:\Program Files\VideoLAN\VLC\vlc.exe", @"C:\Program Files\VideoLAN\VLC\uninstall.exe", "/S"),
            new ApplicationObject("7-Zip", "https://www.7-zip.org", "7-ZipSetup.exe", true, "/S", @"C:\Program Files\7-Zip\7zFM.exe", @"C:\Program Files\7-Zip\Uninstall.exe", "/S"),
            new ApplicationObject("Rufus", "https://rufus.ie/en_US", "Rufus.exe", false, "", "", "", ""),
            new ApplicationObject("BCUninstaller", "https://osdn.net/projects/bulk-crap-uninstaller/releases", "BCUninstaller.exe", true, "/verysilent", @"C:\Program Files\BCUninstaller\BCUninstaller.exe", @"C:\Program Files\BCUninstaller\unins000.exe", "/verysilent"),
            new ApplicationObject("Advanced IP Scanner", "https://www.advanced-ip-scanner.com", "AdvancedIPScanner.exe", false, "", "", "", ""),
            new ApplicationObject("Hardware Info", "https://www.hwinfo.com/download", "HWInfoSetup.exe", true, "/verysilent", @"C:\Program Files\HWiNFO64\HWiNFO64.EXE", @"C:\Program Files\HWiNFO64\unins000.exe", "/verysilent"),
            new ApplicationObject("qBittorrent", "https://www.qbittorrent.org/download.php", "qBittorrentSetup.exe", true, "/S", @"C:\Program Files\qBittorrent\qbittorrent.exe", @"C:\Program Files\qBittorrent\uninst.exe", "/S"),
            new ApplicationObject("Tor Browser", "https://www.torproject.org/download", "TorBrowser.exe", false, "", "", "", ""),
            new ApplicationObject("Freezer", "https://freezer.life/api/versions", "Freezer.exe", false, "", "", "", ""),
            new ApplicationObject("Norton Uninstaller", "https://norton.com/nrnr", "NortonUninstaller.exe", false, "", "", "", ""),
            new ApplicationObject("McAfee Uninstaller", "https://download.mcafee.com/molbin/iss-loc/SupportTools/MCPR/MCPR.exe", "McAfeeUninstaller.exe", false, "", "", "", ""),
            new ApplicationObject("AVG Uninstaller", "https://install.avcdn.net/avg/iavs9x/avgclear.exe", "AVGUninstaller.exe", false, "", "", "", ""),
            new ApplicationObject("Avast Uninstaller", "https://files.avast.com/iavs9x/avastclear.exe", "AvastUninstaller.exe", false, "", "", "", ""),
            new ApplicationObject("Kaspersky Uninstaller", "https://media.kaspersky.com/utilities/ConsumerUtilities/kavremvr.exe", "KasperskyUninstaller.exe", false, "", "", "", ""),
            //new ApplicationObject("RasPi Imager", "https://downloads.raspberrypi.org/imager/imager_latest.exe", "RasPiImager.exe", false, "", "", "", ""),
            // Raspi Imager works here, but it does need installing. Unfortunately, it has no commandline options for silent install :(
        };

        // Variables for DownloadURL() & Install()
        public ApplicationObject AppToDL = new ApplicationObject("", "", "", false, "", "", "", "");
        public ApplicationObject AppToInstall = new ApplicationObject("", "", "", false, "", "", "", "");
        public bool InstallAfterDL = false;
        public bool RunAfterInstall = false;
        public bool DLInProgress = false;
        public bool CanceledByUser = false;
        #endregion

        public ControlCenterForm()
        {
            InitializeComponent();
            if (!Environment.Is64BitOperatingSystem)
            {
                MessageBox.Show("This is not a 64 bit OS. Application will terminate.");
                this.Close();
            }
            workdir = userprofile + @"\AppData\Local\Temp";
            Directory.CreateDirectory($"{workdir}\\DebloatUtils");
            workdir = workdir + "\\DebloatUtils";
            foreach (ApplicationObject app in Applications)
                FilesCheckedListBox.Items.Add(app.Name);
        }

        // Handle button clicks
        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("CancelButton"))
            {
                SetEnableStatus(false);
            }
            else if (button.Name.Equals("OpenDLFolderButton"))
            {
                Process.Start(workdir);
            }
            else if (button.Name.Equals("CleanUpButton"))
            {
                foreach (string file in Directory.GetFiles(workdir))
                    File.Delete(file);
                foreach (string dir in Directory.GetDirectories(workdir))
                    Directory.Delete(dir, true);
                LogMessage("All downloaded and extracted files cleaned.");
            }
            else if (button.Name.Equals("DownloadButton"))
            {
                SetEnableStatus(true);

                InstallAfterDL = InstallCheckBox.Checked;
                RunAfterInstall = RunCheckBox.Checked;

                Thread thread = new Thread(DownloadMain);
                thread.Start();
            }
            else if (button.Name.Equals("UninstallButton"))
            {
                Thread thread = new Thread(UninstallMain);
                thread.Start();
            }
            else if (button.Name.Equals("AutoOOSUButton"))
            {
                Thread thread = new Thread(AutoRunOOSU10);
                thread.Start();
            }
            else if (button.Name.Equals("SendBugReportButton"))
            {
                new BugReportForm().ShowDialog();
            }

            #region Shortcut Button Handling
            else if (button.Name.Equals("WindowsToolsButton"))
                Process.Start(@"C:\Windows\System32\control.exe", "/name Microsoft.AdministrativeTools");
            else if (button.Name.Equals("WinverButton"))
                Process.Start(@"winver");
            else if (button.Name.Equals("ControlPanelButton"))
                Process.Start($"{windir}" + @"\System32\control.exe");
            else if (button.Name.Equals("CmdButton"))
                Process.Start($"{appdata}" + @"\Microsoft\Windows\Start Menu\Programs\System Tools\Command Prompt.lnk");
            else if (button.Name.Equals("PowerShellButton"))
                Process.Start($"{appdata}" + @"\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\Windows PowerShell.lnk");
            else if (button.Name.Equals("ProgramsAndFeaturesButton"))
                Process.Start(new ProcessStartInfo($"{windir}" + @"\System32\control.exe", "/name Microsoft.ProgramsAndFeatures"));
            else if (button.Name.Equals("DeviceManagerButton"))
                Process.Start(new ProcessStartInfo($"{windir}" + @"\System32\control.exe", "/name Microsoft.DeviceManager"));
            else if (button.Name.Equals("DevicesAndPrintersButton"))
                Process.Start(new ProcessStartInfo($"{windir}" + @"\System32\control.exe", "/name Microsoft.DevicesAndPrinters"));
            else if (button.Name.Equals("ComputerManagementButton"))
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Administrative Tools\Computer Management.lnk");
            #endregion
        }

        #region Download, Install, Uninstall
        // Downloads items one at a time, on a separate thread from main window thread.
        private void DownloadMain()
        {
            foreach (string title in GetCheckedBoxes(FilesCheckedListBox))
            {
                if (CanceledByUser)
                    break;
                foreach (ApplicationObject app in Applications)
                    if (app.Name.Equals(title))
                        AppToDL = app;
                Thread thread = new Thread(DownloadURL);
                thread.Start();
                DLInProgress = true;        // Blocks thread so downloads execute 1 by 1. Find a way for multithreaded progress bars??
                while (DLInProgress) { }
            }
            SetEnableStatus(false);
        }

        // Add functionality to skip download if file already exists??
        // Downloads the file, called from DownloadMain(). Keeping as seperate functions for now b/c possible future multithreaded downloads?? See comment in DownloadMain()
        private void DownloadURL()
        {
            LogMessage($"Downloading {AppToDL.Name}...");
            WebClient client = new WebClient();
            client.DownloadProgressChanged += (s, e) =>
            {
                this.InvokeEx(f => f.CurrentDownloadStatsLabel.Text = $"Downloading {AppToDL.Name}; {GetSizeInMetric(e.BytesReceived)} / {GetSizeInMetric(e.TotalBytesToReceive)}; {e.ProgressPercentage}% complete.");
                this.InvokeEx(f => f.CurrentDownloadProgressBar.Value = e.ProgressPercentage);
            };
            Task task = client.DownloadFileTaskAsync(ParseLink(AppToDL.Url), $"{workdir}\\{AppToDL.Filename}");
            while (!task.IsCompleted && !CanceledByUser) { } // Client is downloading the file asynchronously, block the thread until it's finished or canceled by user.
            if (CanceledByUser)
            {
                client.CancelAsync();
                LogMessage("Operation canceled by user.");
                File.Delete(AppToDL.Filename);
                this.InvokeEx(f => f.CurrentDownloadStatsLabel.Text = "0MB / 0MB; 0% complete");
                this.InvokeEx(f => f.CurrentDownloadProgressBar.Value = 0);
            }
            else
            {
                LogMessage($"Download of {AppToDL.Name} completed successfully.");
                if (InstallAfterDL)
                {
                    AppToInstall = AppToDL;
                    Thread thread = new Thread(Install);
                    thread.Start();
                }
            }
            DLInProgress = false;
        }

        // Installs items one at a time, on a separate thread from main window thread.
        private void Install()
        {
            LogMessage($"Installing {AppToInstall.Name}...");
            if (!AppToInstall.NeedsInstallation)
            {
                Process.Start($"{workdir}\\{AppToInstall.Filename}");
                LogMessage($"Installation of {AppToInstall.Name} completed successfully.");
            }
            else
            {
                Process.Start(new ProcessStartInfo($"{workdir}\\{AppToInstall.Filename}", AppToInstall.InstallArguments)).WaitForExit();
                LogMessage($"Installation of {AppToInstall.Name} completed successfully.");
                if (RunAfterInstall)
                {
                    LogMessage($"Running {AppToInstall.Name}.");
                    Process.Start(AppToInstall.InstalledLocation);
                }
            }
        }

        // Uninstalls items one at a time, on a separate thread from main window thread.
        private void UninstallMain()
        {
            foreach (string title in GetCheckedBoxes(FilesCheckedListBox))
            {
                LogMessage($"Uninstalling {title}...");
                try
                {
                    if (title.Equals("ESET One Time Scan"))
                    {
                        File.Delete($"{appdata}" + @"\Microsoft\Windows\Start Menu\Programs\ESET Online Scanner.lnk");
                        File.Delete($"{userprofile}" + @"\Desktop\ESET Online Scanner.lnk");
                        try { Directory.Delete($"{userprofile}\\AppData\\Local\\ESET", true); }
                        catch { LogMessage($"{title} appears to no longer be installed on the system."); return; }
                    }
                    else if (title.Equals("Win10 Update Assistant"))
                    {
                        File.Delete(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Windows 10 Update Assistant.lnk");
                        File.Delete($"{userprofile}" + @"\Desktop\Windows 10 Update Assistant.lnk");
                        try { Directory.Delete(@"C:\Windows10Upgrade", true); }
                        catch { LogMessage($"{title} appears to no longer be installed on the system."); return; }
                    }
                    else
                    {
                        foreach (ApplicationObject app in Applications)
                            if (app.Name.Equals(title) && app.NeedsInstallation)
                                Process.Start(new ProcessStartInfo(app.UninstallFilename, app.UninstallArguments)).WaitForExit();
                    }
                    LogMessage($"Uninstall of {title} completed successfully.");
                }
                catch (Win32Exception) { LogMessage($"{title} appears to no longer be installed on the system."); }
            }
        }
        #endregion

        // Parses the links using HTML scraping to get version numbers etc
        private string ParseLink(string URLToParse)
        {
            WebClient client = new WebClient();
            //client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:77.0) Gecko/20100101 Firefox/77.0");
            // Tor Browser
            if (URLToParse.Equals("https://www.torproject.org/download"))
            {
                string version = GetVal(client.DownloadString(URLToParse), new string[] { "<a class=\"downloadLink\" href=\"/dist/torbrowser/" }, "/");
                return $"https://www.torproject.org/dist/torbrowser/{version}/torbrowser-install-win64-{version}_en-US.exe";
            }
            // Freezer
            else if (URLToParse.Equals("https://freezer.life/api/versions"))
            {
                string version = GetVal(client.DownloadString(URLToParse), new string[] { "pc", "latest\": \"" }, "\"");
                return $"https://files.freezer.life/0:/PC/{version}/Freezer%20{version}.exe";
            }
            // qBittorrent
            else if (URLToParse.Equals("https://www.qbittorrent.org/download.php"))
            {
                string version = GetVal(client.DownloadString(URLToParse), new string[] { "Current <strong>stable</strong> version: <strong>qBittorrent v" });
                return $"https://downloads.sourceforge.net/project/qbittorrent/qbittorrent-win32/qbittorrent-{version}/qbittorrent_{version}_x64_setup.exe?r=https%3A%2F%2Fsourceforge.net%2Fprojects%2Fqbittorrent%2Ffiles%2Fqbittorrent-win32%2Fqbittorrent-{version}%2Fqbittorrent_{version}_x64_setup.exe%2Fdownload&ts=1610524401";
            }
            // BCUninstaller
            else if (URLToParse.Equals("https://osdn.net/projects/bulk-crap-uninstaller/releases"))
            {
                string release = GetVal(client.DownloadString(URLToParse), new string[] { "id=\"release-wrap-" }, "\"");
                string version = GetVal(client.DownloadString($"{URLToParse}/{release}"), new string[] { "<title>Release Bulk Crap Uninstaller v" }, " - ");
                return $"https://osdn.net/frs/redir.php?m=nchc&f=bulk-crap-uninstaller%2F{release}%2FBCUninstaller_{version}_setup.exe";
            }
            // Rufus
            else if (URLToParse.Equals("https://rufus.ie/en_US"))
            {
                string version = GetVal(client.DownloadString(URLToParse), new string[] { "Download</span>", ".exe\">Rufus " }, "</a>");
                return $"https://github.com/pbatard/rufus/releases/download/v{version}/rufus-{version}p.exe";
            }
            // HWInfo
            else if (URLToParse.Equals("https://www.hwinfo.com/download"))
            {
                string version = string.Join("", GetVal(client.DownloadString(URLToParse), new string[] { "<sub>Version " }, "</sub>").Split('.'));
                return $"https://www.sac.sk/download/utildiag/hwi_{version}.exe";
            }
            // Advanced IP Scanner
            else if (URLToParse.Equals("https://www.advanced-ip-scanner.com"))
            {
                string version = GetVal(client.DownloadString(URLToParse), new string[] { "https://download.advanced-ip-scanner.com/download/files/Advanced_IP_Scanner_" }, ".exe");
                return $"https://download.advanced-ip-scanner.com/download/files/Advanced_IP_Scanner_{version}.exe";
            }
            // VLC
            else if (URLToParse.Equals("https://www.videolan.org/vlc"))
            {
                string version = GetVal(client.DownloadString(URLToParse), new string[] { "Version <span id='downloadVersion'>" }, "</span>").Trim();
                return $"https://mirrors.syringanetworks.net/videolan/vlc/{version}/win64/vlc-{version}-win64.exe";
            }
            // 7-Zip
            else if (URLToParse.Equals("https://www.7-zip.org"))
            {
                string version = string.Join("", GetVal(client.DownloadString(URLToParse), new string[] { "Download 7-Zip " }, " (").Split('.'));
                return $"https://www.7-zip.org/a/7z{version}-x64.exe";
            }
            // If link doesn't need to be parsed (Malwarebytes, ESET, etc)
            else
            {
                return URLToParse;
            }
        }

        // Downloads OOSU10.exe, extracts config, loads config, applies changes, and exits... silently.
        private void AutoRunOOSU10()
        {
            ApplicationObject app = Applications[5];
            string configFile = $"{workdir}\\OOSU10Config.cfg";
            WebClient client = new WebClient();
            LogMessage("Downloading OOSU10.exe...");
            Task task = client.DownloadFileTaskAsync(ParseLink(app.Url), $"{workdir}\\{app.Filename}");
            while (!task.IsCompleted) { }
            LogMessage("Download of OOSU10.exe completed successfully.");
            File.WriteAllBytes(configFile, Properties.Resources.OOSU10Config);
            LogMessage("Extracted config file successfully.");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = $"{workdir}\\{app.Filename}";
            startInfo.Arguments = $"\"{configFile}\" /quiet";
            Process.Start(startInfo).WaitForExit();
            LogMessage("OOSU10.exe imported config file and applied changes successfully.");
        }

        #region Utility functions
        // Function to help with parsing HTML
        private string GetVal(string html, string[] keys, string endstring = "<", bool includeEndString = false)
        {
            foreach (string key in keys)
            {
                int i = html.IndexOf(key) + key.Length;
                html = html.Substring(i, html.Length - i);
            }
            string out_ = html.Substring(0, includeEndString ? html.IndexOf(endstring) + endstring.Length : html.IndexOf(endstring));
            return out_;
        }

        // Prints message to the LogTextBox control on the main form.
        private void LogMessage(string msg)
        {
            this.InvokeEx(f => f.LogTextBox.Text = msg + Environment.NewLine + f.LogTextBox.Text);      // Newest text goes at the top of textbox
        }

        // Sets enabled statuses for buttons and checkboxes. also updates CanceledByUser
        private void SetEnableStatus(bool CancelAllowed)
        {
            if (CancelAllowed)
            {
                this.InvokeEx(f => f.CancelButton.Enabled = true);
                this.InvokeEx(f => f.DownloadButton.Enabled = false);
                this.InvokeEx(f => f.UninstallButton.Enabled = false);
                this.InvokeEx(f => f.OpenDLFolderButton.Enabled = false);
                this.InvokeEx(f => f.CleanUpButton.Enabled = false);
                this.InvokeEx(f => f.InstallCheckBox.Enabled = false);
                this.InvokeEx(f => f.RunCheckBox.Enabled = false);

                CanceledByUser = false;
            }
            else
            {
                this.InvokeEx(f => f.CancelButton.Enabled = false);
                this.InvokeEx(f => f.DownloadButton.Enabled = true);
                this.InvokeEx(f => f.UninstallButton.Enabled = true);
                this.InvokeEx(f => f.OpenDLFolderButton.Enabled = true);
                this.InvokeEx(f => f.CleanUpButton.Enabled = true);
                this.InvokeEx(f => f.InstallCheckBox.Enabled = true);
                this.InvokeEx(f => f.RunCheckBox.Enabled = true);

                CanceledByUser = true;
            }
            CheckRunCheckBoxAllowed();
        }

        // Turns a number of bytes into "132.58MB" or "13.82GB"
        private string GetSizeInMetric(long numOfBytes)
        {
            string metric = "";
            double size = 0;
            if (numOfBytes < 1000)
            {
                metric = "B";
                size = numOfBytes;
            }
            else if (numOfBytes < 1000000)
            {
                metric = "KB";
                size = Math.Round(numOfBytes / 1024d, 2);   // add the 'd' to 1024 to let the Math.Round function know that it's a <double> data type.
            }
            else if (numOfBytes < 1000000000)
            {
                metric = "MB";
                size = Math.Round(numOfBytes / Math.Pow(1024, 2), 2);
            }
            else if (numOfBytes < 1000000000000)
            {
                metric = "GB";
                size = Math.Round(numOfBytes / Math.Pow(1024, 3), 2);
            }
            else if (numOfBytes < 1000000000000000)
            {
                metric = "TB";
                size = Math.Round(numOfBytes / Math.Pow(1024, 4), 2);
            }
            return $"{size}{metric}";
        }

        // Returns a list of the strings of the text shown on all checked boxes
        private List<string> GetCheckedBoxes(CheckedListBox box)
        {
            List<string> CheckedBoxes = new List<string>();
            for (int i = 0; i < box.Items.Count; i++)
            {
                if (box.GetItemChecked(i))
                    CheckedBoxes.Add(box.Items[i].ToString());
            }
            return CheckedBoxes;
        }

        // Calls CheckRunCheckBoxAllowed()
        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CheckRunCheckBoxAllowed();
        }

        // Disable RunCheckBox if !InstallCheckBox.Checked
        private void CheckRunCheckBoxAllowed()
        {
            if (InstallCheckBox.Checked && InstallCheckBox.Enabled)
                this.InvokeEx(f => f.RunCheckBox.Enabled = true);
            else
                this.InvokeEx(f => f.RunCheckBox.Enabled = false);
        }
        #endregion
    }

    // Allows child threads to access controls that were made on the parent thread
    // Just use 'this.InvokeEx(f => f.ControlName.ActionEtc);
    public static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                // This statement always throws an exception on form close, so I've made an empty catch for it
                try { @this.Invoke(action, new object[] { @this }); }
                catch { }
            }
            else
                action(@this);
        }
    }
}