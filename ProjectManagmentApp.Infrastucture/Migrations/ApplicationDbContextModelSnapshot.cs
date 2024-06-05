﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManagmentApp.Infrastucture;

#nullable disable

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientProject", b =>
                {
                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.HasKey("ClientsId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ClientProject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhaseId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Design UI layout",
                            Name = "Prototype development",
                            PhaseId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = " Implement sensor connectivity.",
                            Name = "Develop sensor integration",
                            PhaseId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Verify voice recognition functionality.",
                            Name = "Test voice commands",
                            PhaseId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Revamp product listing page",
                            Name = "Frontend Redesign",
                            PhaseId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "Streamline payment and shipping options.",
                            Name = "Enhance checkout process",
                            PhaseId = 4
                        });
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "AbcCorp@gmail.com",
                            Name = "ABC Corporation",
                            PhoneNumber = 21454232,
                            Place = "New York"
                        },
                        new
                        {
                            Id = 2,
                            Email = "XYZent@gmail.com",
                            Name = "XYZ Enterprises",
                            PhoneNumber = 46454232,
                            Place = "Washington"
                        },
                        new
                        {
                            Id = 3,
                            Email = "tech@gmail.com",
                            Name = "Tech Innovations Ltd.",
                            PhoneNumber = 51454652,
                            Place = "Moscow"
                        },
                        new
                        {
                            Id = 4,
                            Email = "globalSol@gmail.com",
                            Name = "Global Solutions Inc.",
                            PhoneNumber = 2178532,
                            Place = "Singapur"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Bright@gmail.com",
                            Name = "Bright Future Co.",
                            PhoneNumber = 27564232,
                            Place = "Bejing"
                        });
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Phases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "initial preparations",
                            Name = "First phase of project",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "testing preparations",
                            Name = "Second phase of project",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "testing",
                            Name = "Third phase of project",
                            ProjectId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "final touch and deployment",
                            Name = "Last phase of project",
                            ProjectId = 4
                        });
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("PlannedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PlannedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProjectStatusId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfCreation = new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2098),
                            Description = "Automate household tasks with IoT.",
                            EndDate = new DateTime(2024, 6, 10, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2139),
                            Name = "SmartHome Automation",
                            PlannedEndDate = new DateTime(2024, 7, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2144),
                            PlannedStartDate = new DateTime(2024, 6, 10, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2143),
                            ProjectStatusId = 1,
                            StartDate = new DateTime(2024, 6, 7, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2135)
                        },
                        new
                        {
                            Id = 2,
                            DateOfCreation = new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2177),
                            Description = "Monitor fitness goals and progress.",
                            EndDate = new DateTime(2024, 6, 20, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2179),
                            Name = "Health Tracker App",
                            PlannedEndDate = new DateTime(2024, 7, 6, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2182),
                            PlannedStartDate = new DateTime(2024, 6, 11, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2181),
                            ProjectStatusId = 2,
                            StartDate = new DateTime(2024, 6, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2178)
                        },
                        new
                        {
                            Id = 3,
                            DateOfCreation = new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2184),
                            Description = "Enhance user experience with new features.",
                            EndDate = new DateTime(2024, 6, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2186),
                            Name = "E-commerce Platform Upgrade",
                            PlannedEndDate = new DateTime(2024, 7, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2188),
                            PlannedStartDate = new DateTime(2024, 6, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2187),
                            ProjectStatusId = 2,
                            StartDate = new DateTime(2024, 6, 7, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2185)
                        },
                        new
                        {
                            Id = 4,
                            DateOfCreation = new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2190),
                            Description = "Visualize and analyze large datasets.",
                            EndDate = new DateTime(2024, 6, 19, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2192),
                            Name = "Data Analysis Tool",
                            PlannedEndDate = new DateTime(2024, 7, 3, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2194),
                            PlannedStartDate = new DateTime(2024, 6, 12, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2193),
                            ProjectStatusId = 3,
                            StartDate = new DateTime(2024, 6, 9, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2191)
                        },
                        new
                        {
                            Id = 5,
                            DateOfCreation = new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2196),
                            Description = "Promote renewable energy solutions.",
                            EndDate = new DateTime(2024, 6, 22, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2198),
                            Name = "Green Energy Initiative",
                            PlannedEndDate = new DateTime(2024, 7, 4, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2200),
                            PlannedStartDate = new DateTime(2024, 6, 9, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2199),
                            ProjectStatusId = 4,
                            StartDate = new DateTime(2024, 6, 10, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2197)
                        });
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ProjectClient", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId", "ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("ProjectClients");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ProjectResearcher", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ResearcherId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResearcherRoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId", "ResearcherId");

                    b.HasIndex("ResearcherId");

                    b.HasIndex("ResearcherRoleId");

                    b.ToTable("ProjectResearchers");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ProjectStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ProjectStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Planned"
                        },
                        new
                        {
                            Id = 2,
                            Name = "InProgress"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Active"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Completed"
                        });
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Researcher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("ResearcherRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ResearcherRoleId");

                    b.ToTable("Researchers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "jhon@gmail.com",
                            LastName = "Smith",
                            Name = "Jhon",
                            PhoneNumber = 38163221,
                            ResearcherRoleId = 1,
                            Title = ""
                        },
                        new
                        {
                            Id = 2,
                            Email = "emily@gmail.com",
                            LastName = "Jhonson",
                            Name = "Emily",
                            PhoneNumber = 38163451,
                            ResearcherRoleId = 2,
                            Title = ""
                        },
                        new
                        {
                            Id = 3,
                            Email = "michael@gmail.com",
                            LastName = "Williams",
                            Name = "Michael",
                            PhoneNumber = 38145321,
                            ResearcherRoleId = 3,
                            Title = ""
                        },
                        new
                        {
                            Id = 4,
                            Email = "sarah@gmail.com",
                            LastName = "Brown",
                            Name = "Sarah",
                            PhoneNumber = 38164452,
                            ResearcherRoleId = 4,
                            Title = ""
                        },
                        new
                        {
                            Id = 5,
                            Email = "david@gmail.com",
                            LastName = "Jones",
                            Name = "David",
                            PhoneNumber = 38160533,
                            ResearcherRoleId = 5,
                            Title = ""
                        });
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ResearcherRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResearcherRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TeamManager"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TeamLeader"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Researcher"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tester"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Begginer"
                        });
                });

            modelBuilder.Entity("ProjectResearcher", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<int>("ResearchersId")
                        .HasColumnType("int");

                    b.HasKey("ProjectsId", "ResearchersId");

                    b.HasIndex("ResearchersId");

                    b.ToTable("ProjectResearcher");
                });

            modelBuilder.Entity("ClientProject", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectManagmentApp.Domain.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectManagmentApp.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Activity", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.Phase", "Phase")
                        .WithMany()
                        .HasForeignKey("PhaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phase");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Phase", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Project", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.ProjectStatus", "ProjectStatus")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectStatus");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ProjectClient", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.Client", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectManagmentApp.Domain.Entities.Project", "Projects")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ProjectResearcher", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.Project", "Projects")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectManagmentApp.Domain.Entities.Researcher", "Researchers")
                        .WithMany()
                        .HasForeignKey("ResearcherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectManagmentApp.Domain.Entities.ResearcherRole", "ResearcherRoles")
                        .WithMany()
                        .HasForeignKey("ResearcherRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projects");

                    b.Navigation("ResearcherRoles");

                    b.Navigation("Researchers");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.Researcher", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.ResearcherRole", "ResearcherRole")
                        .WithMany("Researchers")
                        .HasForeignKey("ResearcherRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ResearcherRole");
                });

            modelBuilder.Entity("ProjectResearcher", b =>
                {
                    b.HasOne("ProjectManagmentApp.Domain.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectManagmentApp.Domain.Entities.Researcher", null)
                        .WithMany()
                        .HasForeignKey("ResearchersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ProjectStatus", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("ProjectManagmentApp.Domain.Entities.ResearcherRole", b =>
                {
                    b.Navigation("Researchers");
                });
#pragma warning restore 612, 618
        }
    }
}
