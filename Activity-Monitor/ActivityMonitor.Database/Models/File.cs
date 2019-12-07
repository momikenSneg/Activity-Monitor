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

    class RepositoryConfig : IEntityTypeConfiguration<Repository>
    {
        public void Configure(EntityTypeBuilder<Repository> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .IsRequired();

            builder
                .HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}
