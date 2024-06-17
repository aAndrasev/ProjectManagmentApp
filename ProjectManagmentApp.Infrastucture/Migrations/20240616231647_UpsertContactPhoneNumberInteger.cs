using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagmentApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class UpsertContactPhoneNumberInteger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContactPhoneNumber",
                table: "ProjectClients",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 6, 22, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 7, 17, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9322), new DateTime(2024, 6, 22, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 6, 19, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 7, 2, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 7, 18, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 6, 23, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 6, 20, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 6, 20, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 7, 20, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 6, 20, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9333), new DateTime(2024, 6, 19, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 7, 1, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9338), new DateTime(2024, 7, 15, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9341), new DateTime(2024, 6, 24, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 6, 21, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 7, 4, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 7, 16, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 6, 21, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9345), new DateTime(2024, 6, 22, 1, 16, 47, 664, DateTimeKind.Local).AddTicks(9343) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactPhoneNumber",
                table: "ProjectClients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 6, 18, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 7, 13, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5858), new DateTime(2024, 6, 18, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 6, 15, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5862), new DateTime(2024, 6, 28, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5864), new DateTime(2024, 7, 14, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5867), new DateTime(2024, 6, 19, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5865), new DateTime(2024, 6, 16, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5869), new DateTime(2024, 6, 16, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 7, 16, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5873), new DateTime(2024, 6, 16, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5872), new DateTime(2024, 6, 15, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5875), new DateTime(2024, 6, 27, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5878), new DateTime(2024, 7, 11, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 6, 20, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5879), new DateTime(2024, 6, 17, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "EndDate", "PlannedEndDate", "PlannedStartDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 6, 30, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5884), new DateTime(2024, 7, 12, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5887), new DateTime(2024, 6, 17, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 6, 18, 13, 30, 27, 546, DateTimeKind.Local).AddTicks(5883) });
        }
    }
}
