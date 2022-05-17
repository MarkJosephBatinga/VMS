using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VMS.Server.Migrations
{
    public partial class AddAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appointment_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barangay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Facility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityBarangay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityTown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityProvince = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment_info", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointment_info");
        }
    }
}
