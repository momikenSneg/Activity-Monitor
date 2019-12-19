using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    class Journal
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }
        public string NameChange { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int IssueId { get; set; }
    }
}
