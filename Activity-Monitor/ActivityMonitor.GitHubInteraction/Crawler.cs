using Octokit;
using System.Threading.Tasks;
//using ActivityMonitor.Database.Models;
using System.Collections.Generic;
using ActivityMonitor.Database.Models;

namespace ActivityMonitor.GitHubInteraction
{
    class Crawler
    {
        public readonly string NameOfApp = "Activity-Monitor";
        private readonly GitHubClient client;

        public Crawler(string login, string password)
        {
            client = new GitHubClient(new ProductHeaderValue("Activity-Monitor"));
            var basicAuth = new Credentials(login, password);
            client.Credentials = basicAuth;
        }

        private List<Database.Models.Repository> repositories = new List<Database.Models.Repository>();
        private List<Developer> developers = new List<Developer>();
        private List<File> files = new List<File>();
        private List<Database.Models.Commit> commits = new List<Database.Models.Commit>();
    }
}
