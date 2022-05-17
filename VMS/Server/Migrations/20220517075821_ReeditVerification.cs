using Microsoft.EntityFrameworkCore.Migrations;

namespace VMS.Server.Migrations
{
    public partial class ReeditVerification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user_info");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_info",
                table: "user_info",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "verify_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VaccImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_verify_info", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "verify_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_info",
                table: "user_info");

            migrationBuilder.RenameTable(
                name: "user_info",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
