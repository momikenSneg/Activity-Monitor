using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public enum FileAction
    {
        Created = 0,
        Modified = 1,
        Deleted = 2
    }
    public class CommitFile
    {
        public Guid CommitId { get; set; }
        public Commit Commit { get; set; }
        public Guid FileId { get; set; }
        public File File { get; set; }
        public FileAction Action { get; set; }

    }
}
