using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IT.AssetManagement.Migrations
{
    public partial class SeedAssetsHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 1, 6, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 2, 7, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 3, 8, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });

            migrationBuilder.InsertData(
                table: "AssetsHistory",
                columns: new[] { "Id", "AssetId", "AssignedDate", "StaffId", "UnAssignedDate" },
                values: new object[] { 4, 9, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AssetsHistory",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
