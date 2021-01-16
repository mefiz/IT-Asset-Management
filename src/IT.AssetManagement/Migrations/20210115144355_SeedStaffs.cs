using Microsoft.EntityFrameworkCore.Migrations;

namespace IT.AssetManagement.Migrations
{
    public partial class SeedStaffs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 1, 1, "Ahmed Mohamed", "A123456", "A001" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 2, 1, "Hussain Ali", "A223422", "A002" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 3, 2, "Fathimath Moosa Manik", "A323433", "B003" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 4, 2, "Ibrahim Hussain", "A423444", "A017" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 5, 3, "Aishath Mariyam", "A523455", "EE01" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "Name", "NID", "StaffNumber" },
                values: new object[] { 6, 3, "Hassan Ali Ibrahim", "A623466", "AE001" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
