using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelSystem.Migrations
{
    public partial class UpdatedStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Departments_DepartmentId",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Gender_GenderId",
                table: "Staff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.RenameTable(
                name: "Staff",
                newName: "Staffs");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_GenderId",
                table: "Staffs",
                newName: "IX_Staffs_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_DepartmentId",
                table: "Staffs",
                newName: "IX_Staffs_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Departments_DepartmentId",
                table: "Staffs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Gender_GenderId",
                table: "Staffs",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Departments_DepartmentId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Gender_GenderId",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Staff");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_GenderId",
                table: "Staff",
                newName: "IX_Staff_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staff",
                newName: "IX_Staff_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Departments_DepartmentId",
                table: "Staff",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Gender_GenderId",
                table: "Staff",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
