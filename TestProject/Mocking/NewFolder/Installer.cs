using System.Net;

namespace TestCasesProject.Mocking.NewFolder
{
    public interface IInstaller
    {
        bool DownloadFile(string path, string _setupDestinationFile);
    }

    public class Installer : IInstaller
    {

        public bool DownloadFile(string path, string _setupDestinationFile)
        {
            
            try
            {
                var client = new WebClient();
                client.DownloadFile(path, _setupDestinationFile);
                       
                return true;
            }
            catch (WebException ex)
            {

                return false;
            }

        }
    }
}
