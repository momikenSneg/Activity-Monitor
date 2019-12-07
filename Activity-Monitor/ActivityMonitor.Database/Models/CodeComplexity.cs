using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database.Models
{
    public class CodeComplexity
    {
        public Guid Id { get; set; }
        public Guid RepositoryId { get; set; }
        public Repository Repository { get; set; }
        public DateTimeOffset CalculatedAt { get; set; }
        public int Value { get; set; }
    }
}
