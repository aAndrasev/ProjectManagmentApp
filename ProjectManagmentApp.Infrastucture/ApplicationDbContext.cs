using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ProjectClient> ProjectClients { get; set; }
        public DbSet<ProjectResearcher> ProjectResearchers { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<Researcher> Researchers { get; set; }
        public DbSet<ResearcherRole> ResearcherRoles { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
            new Project() { Id = 1, Name = "SmartHome Automation", Description = "Automate household tasks with IoT.",DateOfCreation = DateTime.Now,PlannedStartDate = DateTime.Now.AddDays(5), PlannedEndDate = DateTime.Now.AddDays(30),ProjectStatusId = 1},
            new Project() { Id = 2, Name = "Health Tracker App", Description = "Monitor fitness goals and progress.", DateOfCreation = DateTime.Now, PlannedStartDate = DateTime.Now.AddDays(6), PlannedEndDate = DateTime.Now.AddDays(31), ProjectStatusId = 2 },
            new Project() { Id = 3, Name = "E-commerce Platform Upgrade", Description = "Enhance user experience with new features.", DateOfCreation = DateTime.Now, PlannedStartDate = DateTime.Now.AddDays(3), PlannedEndDate = DateTime.Now.AddDays(33), ProjectStatusId = 2 },
            new Project() { Id = 4, Name = "Data Analysis Tool", Description = "Visualize and analyze large datasets.", DateOfCreation = DateTime.Now, PlannedStartDate = DateTime.Now.AddDays(7), PlannedEndDate = DateTime.Now.AddDays(28), ProjectStatusId = 3 },
            new Project() { Id = 5, Name = "Green Energy Initiative", Description = "Promote renewable energy solutions.", DateOfCreation = DateTime.Now, PlannedStartDate = DateTime.Now.AddDays(4), PlannedEndDate = DateTime.Now.AddDays(29), ProjectStatusId = 4     }
            );

            modelBuilder.Entity<Researcher>().HasData(
            new Researcher() { Id = 1, Name = "Jhon", LastName = "Smith", Email = "jhon@gmail.com", Title = "", PhoneNumber = 0038163221 },
            new Researcher() { Id = 2, Name = "Emily", LastName = "Jhonson", Email = "emily@gmail.com", Title = "", PhoneNumber = 0038163451 },
            new Researcher() { Id = 3, Name = "Michael", LastName = "Williams", Email = "michael@gmail.com", Title = "", PhoneNumber = 0038145321 },
            new Researcher() { Id = 4, Name = "Sarah", LastName = "Brown", Email = "sarah@gmail.com", Title = "", PhoneNumber = 0038164452 },
            new Researcher() { Id = 5, Name = "David", LastName = "Jones", Email = "david@gmail.com", Title = "", PhoneNumber = 0038160533 }
            );

            modelBuilder.Entity<ResearcherRole>().HasData(
            new ResearcherRole() { Id = 1, Name = "TeamManager" },
            new ResearcherRole() { Id = 2, Name = "TeamLeader" },
            new ResearcherRole() { Id = 3, Name = "Researcher" },
            new ResearcherRole() { Id = 4, Name = "Tester" },
            new ResearcherRole() { Id = 5, Name = "Begginer" }
            );

            modelBuilder.Entity<Client>().HasData(
            new Client() { Id = 1, Name = "ABC Corporation", Email = "AbcCorp@gmail.com", PhoneNumber = 0021454232, Place = "New York" },
            new Client() { Id = 2, Name = "XYZ Enterprises", Email = "XYZent@gmail.com", PhoneNumber = 0046454232, Place = "Washington" },
            new Client() { Id = 3, Name = "Tech Innovations Ltd.", Email = "tech@gmail.com", PhoneNumber = 0051454652, Place = "Moscow" },
            new Client() { Id = 4, Name = "Global Solutions Inc.", Email = "globalSol@gmail.com", PhoneNumber = 002178532, Place = "Singapur" },
            new Client() { Id = 5, Name = "Bright Future Co.", Email = "Bright@gmail.com", PhoneNumber = 0027564232, Place = "Bejing" }
            );

            modelBuilder.Entity<Phase>().HasData(
            new Phase() { Id = 1, Name = "First phase of project", Description = "initial preparations", ProjectId = 1 },
            new Phase() { Id = 2, Name = "Second phase of project", Description = "testing preparations", ProjectId = 2 },
            new Phase() { Id = 3, Name = "Third phase of project", Description = "testing", ProjectId = 3 },
            new Phase() { Id = 4, Name = "Last phase of project", Description = "final touch and deployment", ProjectId = 4 }
            );

            modelBuilder.Entity<Activity>().HasData(
            new Activity() { Id = 1, Name = "Prototype development", Description = "Design UI layout", PhaseId = 1 },
            new Activity() { Id = 2, Name = "Develop sensor integration", Description = " Implement sensor connectivity.", PhaseId = 2 },
            new Activity() { Id = 3, Name = "Test voice commands", Description = "Verify voice recognition functionality.", PhaseId = 3 },
            new Activity() { Id = 4, Name = "Frontend Redesign", Description = "Revamp product listing page", PhaseId = 4 },
            new Activity() { Id = 5, Name = "Enhance checkout process", Description = "Streamline payment and shipping options.", PhaseId = 4 }
            );

            modelBuilder.Entity<ProjectStatus>().HasData(
            new ProjectStatus() { Id = 1, Name = "Planned" },
            new ProjectStatus() { Id = 2, Name = "InProgress" },
            new ProjectStatus() { Id = 3, Name = "Active" },
            new ProjectStatus() { Id = 4, Name = "Completed" }
            );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProjectClient>()
                        .HasKey(x => new { x.ProjectId, x.ClientId });
            modelBuilder.Entity<ProjectResearcher>()
                        .HasKey(x => new { x.ProjectId, x.ResearcherId });
        }
    }
}
