using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IT.AssetManagement.Migrations
{
    public partial class SeedAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 1, "C8619B9", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 2, "C8619BA", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 3, "C8619BB", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 4, "C8619BC", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 5, "C8619BD", null, null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 6, "C8619C2", null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 7, "C8619C3", null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 8, "C8619C4", null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 9, "C8619C5", null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 10, "C861A26", new DateTime(2021, 1, 20, 14, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetNumber", "DiscardedDate", "LastAssignedDate", "PurchasedDate", "Status", "TypeId" },
                values: new object[] { 11, "C861A27", new DateTime(2021, 1, 20, 14, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
