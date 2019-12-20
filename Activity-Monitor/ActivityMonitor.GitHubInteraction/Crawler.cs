﻿using Octokit;
using System.Threading.Tasks;
using ActivityMonitor.Database.Models.Git;
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

        private List<Repository> repositories = new List<Repository>();
        private List<Developer> developers = new List<Developer>();
        private List<File> files = new List<File>();
        private List<Database.Models.Commit> commits = new List<Database.Models.Commit>();

        public async Task Gathering(RepositoryAttribute [] attributes)
        {
            foreach (var attribute in attributes)
            {
                var owner = attribute.owner;
                var name = attribute.name;
                //var repo = new Database.Models.Repository { OwnersLogin = owner, Name = name};
                var contrs = await client.Repository.Statistics.GetContributors(owner, name);
                foreach(var contr in contrs)
                {
                    //if contributors isn't contains in list
                    if(true)
                    {

                    }
                    else 
                    { 

                    }
                }
                //repositories.Add(repo);
            }
        }
    }
}

