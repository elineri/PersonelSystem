using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelSystem.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "HR" },
                    { 2, "Economy" },
                    { 3, "Sales" },
                    { 4, "It" },
                    { 5, "Management" },
                    { 6, "Administration" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "City", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Salary", "StreetAdress", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Varberg", 4, "eline@mail.com", "Elin", "Female", "Ericstam", "070-12312312", 30000m, "Gatan 2", "43237" },
                    { 2, "Göteborg", 2, "oskarj@mail.com", "Oskar", "Male", "Johansson", "070-12312343", 32000m, "Gatan 5", "43243" },
                    { 3, "Kungsbacka", 5, "michaels@mail.com", "Michael", "Male", "Scott", "070-43212312", 30000m, "Vägen 12", "42345" },
                    { 4, "Göteborg", 6, "pamb@mail.com", "Pam", "Female", "Beesly", "070-12357312", 33000m, "Vägen 32", "43242" },
                    { 5, "Göteborg", 3, "jimh@mail.com", "Jim", "Male", "Halpert", "070-12357398", 31000m, "Vägen 54", "43242" },
                    { 6, "Varberg", 2, "angelam@mail.com", "Angela", "Female", "Martin", "070-12357312", 30000m, "Gatan 5", "43236" },
                    { 7, "Varberg", 1, "tobyf@mail.com", "Toby", "Male", "Flenderson", "070-56757312", 34000m, "Gatan 76", "43238" },
                    { 8, "Varberg", 3, "dwights@mail.com", "Dwight", "Male", "Schrute", "073-56123312", 33000m, "Gatan 7", "43236" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DepartmentId",
                table: "Staff",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
