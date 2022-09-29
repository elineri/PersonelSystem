using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelSystem.Migrations
{
    public partial class GenderSeperatedToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[] { 1, "Female" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[] { 2, "Male" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[] { 3, "Other" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "GenderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "GenderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "GenderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "GenderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "GenderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "GenderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "GenderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "GenderId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_GenderId",
                table: "Staff",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Gender_GenderId",
                table: "Staff",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Gender_GenderId",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_Staff_GenderId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Staff");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "Gender",
                value: "Male");
        }
    }
}
