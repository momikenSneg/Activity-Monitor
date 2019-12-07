using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public class CommitFile
    {
        public Guid CommitId { get; set; }
        public Commit Commit { get; set; }
        public Guid FileId { get; set; }
        public File File { get; set; }
        public int Action { get; set; }

    }
}
