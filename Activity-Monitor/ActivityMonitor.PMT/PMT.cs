using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.Serialization.Json;
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

        public override async Task<Membership[]> GetProjectUsers(int id)
        {
            string url = $"/projects/{id}/memberships.json";
            var str = await base._client.GetStringAsync(url);
            var memberships = JsonConvert.DeserializeObject<Memberships>(str);

            return memberships.memberships;
        }

        public override async Task<IssueHistory[]> GetTaskHistory(int id)
        {
            string url = $"/issues/{id}.json?include=journals";
            var str = await base._client.GetStringAsync(url);
            var issueHistory = JsonConvert.DeserializeObject<ForProjectHistory>(str);

            return issueHistory.issue.journals;
        }

        public override async Task<Issues> GetTaskList(int id, int offset)
        {
            string url = $"/issues.json?project_id={id}&offset={offset}";
            var str = await base._client.GetStringAsync(url);
            var issues = JsonConvert.DeserializeObject<Issues>(str);

            return issues;
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
    public class Issues
    {
        public Issue[] issues { get; set; }

}
    public class Issue
    {
        public int id { get; set; }
        public IdName tracker { get; set; }
        public IdName status { get; set; }
        public IdName priority { get; set; }
        public IdName author { get; set; }
        public IdName assigned_to { get; set; }
        public string subject { get; set; }
        public DateTime start_date { get; set; }
        public DateTime due_date { get; set; }
        public int done_ratio { get; set; }
        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }
        public IssueHistory[] journals { get; set; }
    }
    class ForProjectHistory
    {
        public Issue issue { get; set; }
    }
    public class IssueHistory
    {
        public int id { get; set; }
        public IdName user { get; set; }
        public string notes { get; set; }
        public DateTime created_on { get; set; }
        public Details[] details { get; set; }
    }
    public class Details
    {
        public string property { get; set; }
        public string name { get; set; }
        public string old_value { get; set; }
        public string new_value { get; set; }
    }
}
