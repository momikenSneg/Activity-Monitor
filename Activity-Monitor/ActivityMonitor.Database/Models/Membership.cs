using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProjectMembership> Projects { get; set; }
        //public ICollection<Issue> Issues { get; set; }
    }


}
