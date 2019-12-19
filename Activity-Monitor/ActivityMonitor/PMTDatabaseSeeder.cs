using ActivityMonitor.Database;
using ActivityMonitor.Database.Models;
using ActivityMonitor.PMT;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ActivityMonitor
{
    class PMTDatabaseSeeder : IDatabaseSeeder
    {
        private ActivityContext context;
        private List<string> prj;
        private APMT pmt;
        public PMTDatabaseSeeder(ActivityContext c, List<string> projects, string name, string password, string url)
        {
            context = c;
            prj = projects;
            pmt = new PMT.PMT(name, password, new Uri(url));
        }
        public void Seed()
        {
            throw new NotImplementedException();
        }

        private async Task<List<Database.Models.Project>> FillProjects()
        {
            List<Database.Models.Project> save = new List<Database.Models.Project>();
            var projects = await pmt.GetProjects();
            for (int i = 0; i < projects.Length; i++)
            {
                if (!prj.Contains(projects[i].name))
                    continue;
                Database.Models.Project one = new Database.Models.Project
                {
                    Id = projects[i].id,
                    Name = projects[i].name,
                    Description = projects[i].description,
                    Status = projects[i].status,
                    Created_on = projects[i].created_on,
                    Updated_on = projects[i].updated_on
                };

                context.Projects.Add(one);
                save.Add(one);
            }
            return save;
        }

        private async void FillMembership(int projId)
        {
            
        }

        private async Task<List<Tuple<Issue, string>>> FillIssues(int projId)
        {
           
        }

        //TODO: добавлять в историю первое изменение на асайн то
        private async void FillIssueHistory(Tuple<Issue, string> issue)
        {
            
        }
    }
}
