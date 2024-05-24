using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedEndDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedStartDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Researcher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researcher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearcherRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearcherRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientProject",
                columns: table => new
                {
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProject", x => new { x.ClientsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_ClientProject_Client_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectResearcher",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "int", nullable: false),
                    ResearchersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectResearcher", x => new { x.ProjectsId, x.ResearchersId });
                    table.ForeignKey(
                        name: "FK_ProjectResearcher_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectResearcher_Researcher_ResearchersId",
                        column: x => x.ResearchersId,
                        principalTable: "Researcher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProjectStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Planned" },
                    { 2, "InProgress" },
                    { 3, "Active" },
                    { 4, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "ResearcherRole",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TeamManager" },
                    { 2, "TeamLeader" },
                    { 3, "Researcher" },
                    { 4, "Tester" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientProject_ProjectsId",
                table: "ClientProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectResearcher_ResearchersId",
                table: "ProjectResearcher",
                column: "ResearchersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientProject");

            migrationBuilder.DropTable(
                name: "ProjectResearcher");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ResearcherRole");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Researcher");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PlannedEndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PlannedStartDate",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 22, 15, 59, 47, 314, DateTimeKind.Local).AddTicks(9048), "Xiaomi", new DateTime(2024, 5, 18, 15, 59, 47, 314, DateTimeKind.Local).AddTicks(8986) },
                    { 2, new DateTime(2024, 6, 17, 15, 59, 47, 314, DateTimeKind.Local).AddTicks(9053), "Apple", new DateTime(2024, 5, 17, 15, 59, 47, 314, DateTimeKind.Local).AddTicks(9051) }
                });
        }
    }
}
