using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Solution.Migrations
{
    public partial class controllerChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reviews",
                table: "Destinations",
                newName: "Review");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Review",
                table: "Destinations",
                newName: "Reviews");
        }
    }
}
