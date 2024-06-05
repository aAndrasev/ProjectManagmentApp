using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddResearcherRoleToResearcherEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResearcherRoleId",
                table: "Researchers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2098), new DateTime(2024, 6, 10, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 7, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 6, 10, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2143), new DateTime(2024, 6, 7, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 6, 20, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2179), new DateTime(2024, 7, 6, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2182), new DateTime(2024, 6, 11, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 6, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 6, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 7, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2188), new DateTime(2024, 6, 8, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2187), new DateTime(2024, 6, 7, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2190), new DateTime(2024, 6, 19, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 7, 3, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 6, 12, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 6, 9, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 5, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 6, 22, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 7, 4, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 6, 9, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 6, 10, 9, 54, 18, 62, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResearcherRoleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResearcherRoleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResearcherRoleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResearcherRoleId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Researchers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResearcherRoleId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Researchers_ResearcherRoleId",
                table: "Researchers",
                column: "ResearcherRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Researchers_ResearcherRoles_ResearcherRoleId",
                table: "Researchers",
                column: "ResearcherRoleId",
                principalTable: "ResearcherRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Researchers_ResearcherRoles_ResearcherRoleId",
                table: "Researchers");

            migrationBuilder.DropIndex(
                name: "IX_Researchers_ResearcherRoleId",
                table: "Researchers");

            migrationBuilder.DropColumn(
                name: "ResearcherRoleId",
                table: "Researchers");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2586), null, new DateTime(2024, 6, 29, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 6, 4, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2650), null, new DateTime(2024, 6, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 6, 5, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2652), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2655), null, new DateTime(2024, 7, 2, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2658), new DateTime(2024, 6, 2, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2656), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2660), null, new DateTime(2024, 6, 27, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2662), new DateTime(2024, 6, 6, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2661), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2665), null, new DateTime(2024, 6, 28, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 6, 3, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2666), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
