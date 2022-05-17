using Microsoft.EntityFrameworkCore.Migrations;

namespace VMS.Server.Migrations
{
    public partial class AddStudentIdToVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "vaccine_info",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "vaccine_info");
        }
    }
}
