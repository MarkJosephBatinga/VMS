using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VMS.Server.Migrations
{
    public partial class AddVaccinationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VaccDate",
                table: "appointment_info",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaccDate",
                table: "appointment_info");
        }
    }
}
