using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntitiesOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProject_Client_ClientsId",
                table: "ClientProject");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectResearcher_Researcher_ResearchersId",
                table: "ProjectResearcher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResearcherRole",
                table: "ResearcherRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Researcher",
                table: "Researcher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "ResearcherRole",
                newName: "ResearcherRoles");

            migrationBuilder.RenameTable(
                name: "Researcher",
                newName: "Researchers");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResearcherRoles",
                table: "ResearcherRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Researchers",
                table: "Researchers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Phases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phases_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectClients",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectClients", x => new { x.ProjectId, x.ClientId });
                    table.ForeignKey(
                        name: "FK_ProjectClients_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectClients_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectResearchers",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ResearcherId = table.Column<int>(type: "int", nullable: false),
                    ResearcherRoleId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectResearchers", x => new { x.ProjectId, x.ResearcherId });
                    table.ForeignKey(
                        name: "FK_ProjectResearchers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectResearchers_ResearcherRoles_ResearcherRoleId",
                        column: x => x.ResearcherRoleId,
                        principalTable: "ResearcherRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectResearchers_Researchers_ResearcherId",
                        column: x => x.ResearcherId,
                        principalTable: "Researchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Phases_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "Phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_PhaseId",
                table: "Activities",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Phases_ProjectId",
                table: "Phases",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectClients_ClientId",
                table: "ProjectClients",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectResearchers_ResearcherId",
                table: "ProjectResearchers",
                column: "ResearcherId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectResearchers_ResearcherRoleId",
                table: "ProjectResearchers",
                column: "ResearcherRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProject_Clients_ClientsId",
                table: "ClientProject",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectResearcher_Researchers_ResearchersId",
                table: "ProjectResearcher",
                column: "ResearchersId",
                principalTable: "Researchers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProject_Clients_ClientsId",
                table: "ClientProject");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectResearcher_Researchers_ResearchersId",
                table: "ProjectResearcher");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "ProjectClients");

            migrationBuilder.DropTable(
                name: "ProjectResearchers");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Researchers",
                table: "Researchers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResearcherRoles",
                table: "ResearcherRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Researchers",
                newName: "Researcher");

            migrationBuilder.RenameTable(
                name: "ResearcherRoles",
                newName: "ResearcherRole");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Researcher",
                table: "Researcher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResearcherRole",
                table: "ResearcherRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProject_Client_ClientsId",
                table: "ClientProject",
                column: "ClientsId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectResearcher_Researcher_ResearchersId",
                table: "ProjectResearcher",
                column: "ResearchersId",
                principalTable: "Researcher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
