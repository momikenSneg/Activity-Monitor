using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    class Issue
    {
        public int Id { get; set; }
        public string TrackerName { get; set; }
        public int AuthorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public int ProjectId { get; set; }
    }
}
