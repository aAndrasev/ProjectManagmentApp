using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectClient> ProjectClients { get; set; }
        public DbSet<ProjectResearcher> ProjectResearchers { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<Researcher> Researchers { get; set; }
        public DbSet<ResearcherRole> ResearcherRoles { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResearcherRole>().HasData(
            new ResearcherRole() { Id = 1, Name = "TeamManager" },
            new ResearcherRole() { Id = 2, Name = "TeamLeader" },
            new ResearcherRole() { Id = 3, Name = "Researcher" },
            new ResearcherRole() { Id = 4, Name = "Tester" }
            );
            
            modelBuilder.Entity<ProjectStatus>().HasData(
            new ProjectStatus() { Id = 1, Name = "Planned" },
            new ProjectStatus() { Id = 2, Name = "InProgress" },
            new ProjectStatus() { Id = 3, Name = "Active" },
            new ProjectStatus() { Id = 4, Name = "Completed" }
            );
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProjectClient>()
                        .HasKey(x => new { x.ProjectId,x.ClientId });
            modelBuilder.Entity<ProjectResearcher>()
                        .HasKey(x => new { x.ProjectId, x.ResearcherId });
        }
    }
}
