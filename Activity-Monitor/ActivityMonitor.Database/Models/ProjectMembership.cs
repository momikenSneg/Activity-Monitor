using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    class ProjectMembership
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int MembershipId { get; set; }
        public Membership Membership { get; set; }
    }
}
