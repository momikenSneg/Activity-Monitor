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
            var memberships = await pmt.GetProjectUsers(projId);

            for (int i = 0; i < memberships.Length; i++)
            {
                Database.Models.Membership one = new Database.Models.Membership
                {
                    Id = memberships[i].user.id,
                    Name = memberships[i].user.name
                };

                ProjectMembership pm = new ProjectMembership
                {
                    ProjectId = projId,
                    MembershipId = memberships[i].user.id
                };

                context.Memberships.Add(one);
                context.ProjectMemberships.Add(pm);
            }
        }

        private async Task<List<Tuple<Database.Models.Issue, string>>> FillIssues(int projId)
        {
           
        }

        //TODO: добавлять в историю первое изменение на асайн то
        private async void FillIssueHistory(Tuple<Database.Models.Issue, string> issue)
        {
            
        }

        private string GetStatus(int id)
        {
            switch (id)
            {
                case 1:
                    return "New";
                case 2:
                    return "In Progress";
                case 3:
                    return "Resolved";
                case 4:
                    return "Feedback";
                case 5:
                    return "Closed";
                case 6:
                    return "Rejected";
                case 7:
                    return "Need more info";
            }
            return "non";
        }
    }
}
}
