using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddProjecStatusToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectStatus",
                table: "ProjectStatus");

            migrationBuilder.RenameTable(
                name: "ProjectStatus",
                newName: "ProjectStatuses");

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatusId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectStatuses",
                table: "ProjectStatuses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate", "ProjectStatusId" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2586), new DateTime(2024, 6, 29, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2648), new DateTime(2024, 6, 4, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2643), 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate", "ProjectStatusId" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 6, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 6, 5, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2652), 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate", "ProjectStatusId" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2655), new DateTime(2024, 7, 2, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2658), new DateTime(2024, 6, 2, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2656), 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate", "ProjectStatusId" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 6, 27, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2662), new DateTime(2024, 6, 6, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2661), 3 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate", "ProjectStatusId" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2665), new DateTime(2024, 6, 28, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 6, 3, 11, 24, 50, 664, DateTimeKind.Local).AddTicks(2666), 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectStatuses_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId",
                principalTable: "ProjectStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectStatuses_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectStatuses",
                table: "ProjectStatuses");

            migrationBuilder.DropColumn(
                name: "ProjectStatusId",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "ProjectStatuses",
                newName: "ProjectStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectStatus",
                table: "ProjectStatus",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 6, 28, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1995), new DateTime(2024, 6, 3, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 6, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 6, 4, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 7, 1, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 6, 1, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2004), new DateTime(2024, 6, 26, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2006), new DateTime(2024, 6, 5, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "PlannedEndDate", "PlannedStartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2007), new DateTime(2024, 6, 27, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 6, 2, 20, 54, 13, 148, DateTimeKind.Local).AddTicks(2008) });
        }
    }
}
