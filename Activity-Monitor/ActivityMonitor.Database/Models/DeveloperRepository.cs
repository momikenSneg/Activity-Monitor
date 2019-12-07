using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public class DeveloperRepository
    {
        public Guid DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public Guid RepositoryId { get; set; }
        public Repository Repository { get; set; }
    }
}
