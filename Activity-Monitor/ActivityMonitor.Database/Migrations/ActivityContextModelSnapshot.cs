﻿// <auto-generated />
using System;
using ActivityMonitor.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ActivityMonitor.Database.Migrations
{
    [DbContext(typeof(ActivityContext))]
    partial class ActivityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ActivityMonitor.Database.Models.CodeComplexity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CalculatedAt");

                    b.Property<Guid>("RepositoryId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CalculatedAt");

                    b.HasIndex("RepositoryId");

                    b.ToTable("CodeComplexitySamples");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.CodeString", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreationCommitId");

                    b.Property<Guid?>("DeleteCommitId");

                    b.Property<Guid>("FileId");

                    b.HasKey("Id");

                    b.HasIndex("CreationCommitId");

                    b.HasIndex("DeleteCommitId");

                    b.HasIndex("FileId");

                    b.ToTable("CodeStrings");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Commit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuthorId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("GitId")
                        .IsRequired();

                    b.Property<Guid>("RepositoryId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("GitId")
                        .IsUnique();

                    b.HasIndex("RepositoryId");

                    b.ToTable("Commits");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.CommitFile", b =>
                {
                    b.Property<Guid>("CommitId");

                    b.Property<Guid>("FileId");

                    b.Property<int>("Action");

                    b.HasKey("CommitId", "FileId");

                    b.HasIndex("FileId");

                    b.ToTable("CommitFiles");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Developer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.DeveloperRepository", b =>
                {
                    b.Property<Guid>("DeveloperId");

                    b.Property<Guid>("RepositoryId");

                    b.HasKey("DeveloperId", "RepositoryId");

                    b.HasIndex("RepositoryId");

                    b.ToTable("DeveloperRepositories");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid>("RepositoryId");

                    b.HasKey("Id");

                    b.HasIndex("RepositoryId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("DueDate");

                    b.Property<int?>("MembershipId");

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TrackerName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MembershipId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Journal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("IssueId");

                    b.Property<string>("NameChange")
                        .IsRequired();

                    b.Property<string>("NewValue")
                        .IsRequired();

                    b.Property<string>("Notes")
                        .IsRequired();

                    b.Property<string>("OldValue")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("IssueId");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_on");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<DateTime>("Updated_on");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.ProjectMembership", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<int>("MembershipId");

                    b.HasKey("ProjectId", "MembershipId");

                    b.HasIndex("MembershipId");

                    b.ToTable("ProjectMemberships");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Repository", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.CodeComplexity", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Repository", "Repository")
                        .WithMany("CodeComplexityMeasures")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.CodeString", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Commit", "CreationCommit")
                        .WithMany("CreatedStrings")
                        .HasForeignKey("CreationCommitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ActivityMonitor.Database.Models.Commit", "DeleteCommit")
                        .WithMany("DeletedStrings")
                        .HasForeignKey("DeleteCommitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ActivityMonitor.Database.Models.File", "File")
                        .WithMany("Strings")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Commit", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Developer", "Author")
                        .WithMany("Commits")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ActivityMonitor.Database.Models.Repository", "Repository")
                        .WithMany("Commits")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.CommitFile", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Commit", "Commit")
                        .WithMany("Files")
                        .HasForeignKey("CommitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ActivityMonitor.Database.Models.File", "File")
                        .WithMany("Commits")
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.DeveloperRepository", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Developer", "Developer")
                        .WithMany("Repositories")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ActivityMonitor.Database.Models.Repository", "Repository")
                        .WithMany("Developers")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.File", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Repository", "Repository")
                        .WithMany("Files")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.Issue", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Membership")
                        .WithMany("Issues")
                        .HasForeignKey("MembershipId");

                    b.HasOne("ActivityMonitor.Database.Models.Project")
                        .WithMany("Issues")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ActivityMonitor.Database.Models.ProjectMembership", b =>
                {
                    b.HasOne("ActivityMonitor.Database.Models.Membership", "Membership")
                        .WithMany("Projects")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ActivityMonitor.Database.Models.Project", "Project")
                        .WithMany("Memberships")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
