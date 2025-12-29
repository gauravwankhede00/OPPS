using TestCasesProject.Mocking.NewFolder;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        private IInstaller _installer;
        public InstallerHelper(IInstaller installer)
        {
            _installer = installer;
        }
        private string _setupDestinationFile = "";
       

        public bool DownloadInstaller(string customerName, string installerName)
        {
           return _installer.DownloadFile(string.Format("http://example.com/{0}/{1}",
                customerName,
                installerName), _setupDestinationFile);
        }
    }
}