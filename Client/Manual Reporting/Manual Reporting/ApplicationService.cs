using System.Net;

namespace Manual_Reporting
{
    public class ApplicationService
    {
        public string Download(string id)
        {
            var client = new WebClient();
            return client.DownloadString("http://www.dn.se/notfound/url");
        }
    }
}