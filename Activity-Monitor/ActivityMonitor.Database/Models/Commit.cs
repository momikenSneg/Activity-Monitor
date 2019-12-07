using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public class Commit
    {
        public Guid Id { get; set; }
        public string GitId { get; set; }
        public Guid AuthorId { get; set; }
        public Developer Author { get; set; }
        public Guid RepositoryId { get; set; }
        public Repository Repository { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public ICollection<CommitFile> Files { get; set; }
        public ICollection<CodeString> CreatedStrings { get; set; }
        public ICollection<CodeString> DeletedStrings { get; set; }
    }
}
