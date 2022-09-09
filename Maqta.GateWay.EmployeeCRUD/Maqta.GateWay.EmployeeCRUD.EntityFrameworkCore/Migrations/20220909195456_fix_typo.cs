using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore.Migrations
{
    public partial class fix_typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmaiID",
                table: "Employees",
                newName: "EmailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailID",
                table: "Employees",
                newName: "EmaiID");
        }
    }
}
