using ActivityMonitor.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityMonitor.Database
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options)
           : base(options)
        {
        }

        public DbSet<CodeComplexity> CodeComplexitySamples { get; set; }
        public DbSet<CodeString> CodeStrings { get; set; }
        public DbSet<Commit> Commits { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        // Redmine
        public DbSet<Project> Projects { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<ProjectMembership> ProjectMemberships { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ActivityContext).Assembly);
        }
    }
}
