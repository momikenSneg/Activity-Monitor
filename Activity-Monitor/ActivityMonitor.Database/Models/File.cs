using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public Guid RepositoryId { get; set; }
        public Repository Repository { get; set; }
        public string Name { get; set; }
        public ICollection<CommitFile> Commits { get; set; }
        public ICollection<CodeString> Strings { get; set; }
    }
}
