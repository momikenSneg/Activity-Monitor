using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ActivityMonitor.Database.Models;

namespace ActivityMonitor.PMT
{
    class PMT : APMT
    {
        public PMT(string login, string password, Uri pmtUri) : base(login, password, pmtUri)
        {
        }

        public override Task<Project[]> GetProjects()
        {
            throw new NotImplementedException();
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
}
