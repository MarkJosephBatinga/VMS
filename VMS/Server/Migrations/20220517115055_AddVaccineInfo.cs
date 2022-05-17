using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VMS.Server.Migrations
{
    public partial class AddVaccineInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vaccine_info",
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
                    FirstDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstVaccinator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstBatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstLot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondVaccinator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondBatch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondLot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vaccine_info", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vaccine_info");
        }
    }
}
