using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstTestEntriesForEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Place" },
                values: new object[,]
                {
                    { 1, "AbcCorp@gmail.com", "ABC Corporation", 21454232, "New York" },
                    { 2, "XYZent@gmail.com", "XYZ Enterprises", 46454232, "Washington" },
                    { 3, "tech@gmail.com", "Tech Innovations Ltd.", 51454652, "Moscow" },
                    { 4, "globalSol@gmail.com", "Global Solutions Inc.", 2178532, "Singapur" },
                    { 5, "Bright@gmail.com", "Bright Future Co.", 27564232, "Bejing" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DateOfCreation", "Description", "EndDate", "Name", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1953), "Automate household tasks with IoT.", null, "SmartHome Automation", new DateTime(2024, 6, 28, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1995), new DateTime(2024, 6, 3, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1991), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1997), "Monitor fitness goals and progress.", null, "Health Tracker App", new DateTime(2024, 6, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 6, 4, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2001), "Enhance user experience with new features.", null, "E-commerce Platform Upgrade", new DateTime(2024, 7, 1, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 6, 1, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2001), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2004), "Visualize and analyze large datasets.", null, "Data Analysis Tool", new DateTime(2024, 6, 26, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2006), new DateTime(2024, 6, 5, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2007), "Promote renewable energy solutions.", null, "Green Energy Initiative", new DateTime(2024, 6, 27, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 6, 2, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2008), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ResearcherRoles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Begginer" });

            migrationBuilder.InsertData(
                table: "Researchers",
                columns: new[] { "Id", "Email", "LastName", "Name", "PhoneNumber", "Title" },
                values: new object[,]
                {
                    { 1, "jhon@gmail.com", "Smith", "Jhon", 38163221, "" },
                    { 2, "emily@gmail.com", "Jhonson", "Emily", 38163451, "" },
                    { 3, "michael@gmail.com", "Williams", "Michael", 38145321, "" },
                    { 4, "sarah@gmail.com", "Brown", "Sarah", 38164452, "" },
                    { 5, "david@gmail.com", "Jones", "David", 38160533, "" }
                });

            migrationBuilder.InsertData(
                table: "Phases",
                columns: new[] { "Id", "Description", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1, "initial preparations", "First phase of project", 1 },
                    { 2, "testing preparations", "Second phase of project", 2 },
                    { 3, "testing", "Third phase of project", 3 },
                    { 4, "final touch and deployment", "Last phase of project", 4 }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Description", "Name", "PhaseId" },
                values: new object[,]
                {
                    { 1, "Design UI layout", "Prototype development", 1 },
                    { 2, " Implement sensor connectivity.", "Develop sensor integration", 2 },
                    { 3, "Verify voice recognition functionality.", "Test voice commands", 3 },
                    { 4, "Revamp product listing page", "Frontend Redesign", 4 },
                    { 5, "Streamline payment and shipping options.", "Enhance checkout process", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ResearcherRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
