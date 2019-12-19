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

        private async Task<List<Project>> FillProjects()
        {
            List<Project> save = new List<Project>();
            var projects = await pmt.GetProjects();
            for (int i = 0; i < projects.Length; i++)
            {
                if (!prj.Contains(projects[i].name))
                    continue;
                Project one = new Project
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
    }
}
