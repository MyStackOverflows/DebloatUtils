using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebloatUtils
{
    public class ApplicationObject
    {
        public string Name;
        public string Url;
        public string Filename;
        public bool NeedsInstallation;
        public string InstallArguments;
        public string InstalledLocation;
        public string UninstallFilename;
        public string UninstallArguments;

        public ApplicationObject(string name, string url, string filename, bool needsInstallation, string installArguments, string installedLocation, string uninstallFilename, string uninstallArguments)
        {
            this.Name = name;
            this.Url = url;
            this.Filename = filename;
            this.NeedsInstallation = needsInstallation;
            this.InstallArguments = installArguments;
            this.InstalledLocation = installedLocation;
            this.UninstallFilename = uninstallFilename;
            this.UninstallArguments = uninstallArguments;
        }
    }
}
