using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public class CodeString
    {
        public Guid Id { get; set; }
        public Guid FileId { get; set; }
        public File File { get; set; }
        public Guid CreationCommitId { get; set; }
        public Commit CreationCommit { get; set; }
        public Guid? DeleteCommitId { get; set; }
        public Commit DeleteCommit { get; set; }
    }
}
