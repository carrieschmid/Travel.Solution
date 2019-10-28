using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Solution.Migrations
{
    public partial class SeedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Rating", "Review" },
                values: new object[,]
                {
                    { 2, "Oakland", "USA", 2, "Sunny, mild, rough" },
                    { 3, "Sayulita", "Mexico", 4, "Crowded and touristy, but still beautiful and warm." },
                    { 4, "Santiago", "Chile", 3, "Busy, a little smoggy, gorgeous mountains" },
                    { 5, "Lagos", "Nigeria", 5, "Vast, expansive" },
                    { 6, "Cairo", "Eqypt", 5, "So many incredible places to visit" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6);
        }
    }
}
