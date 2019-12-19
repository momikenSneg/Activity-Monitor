using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ActivityMonitor.PMT
{
    public class PMT : APMT
    {
        public PMT(string login, string password, Uri pmtUri) : base(login, password, pmtUri)
        {
        }

        public override async Task<Project[]> GetProjects()
        {
            var str = await _client.GetStringAsync("/projects.json");
            var projects = JsonConvert.DeserializeObject<Projects>(str);

            return projects.projects;
        }

        public override Task<Membership[]> GetProjectUsers(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<string[]> GetTaskHistory(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<Issue[]> GetTaskList(int id)
        {
            throw new NotImplementedException();
        }
    }

    class Projects
    {
        public Project[] projects { get; set; }
    }

    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public CustomFields[] custom_fields { get; set; }
        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }
    }

    public class CustomFields
    {
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }

    class Memberships
    {
        public Membership[] memberships { get; set; }
    }
    public class Membership
    {
        public int id { get; set; }
        public IdName user { get; set; }
        public IdName[] roles { get; set; }
    }
    public class IdName
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
