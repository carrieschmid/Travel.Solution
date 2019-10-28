using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Solution.Migrations
{
    public partial class ExtraSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "Rating",
                value: 3);

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Rating", "Review" },
                values: new object[,]
                {
                    { 30, "Kiev", "Ukraine", 1, "Violent, dangerous, terrible" },
                    { 31, "Kingston", "Jamaica", 4, "Mellow, warm, colorful, crowded" },
                    { 32, "Ocho Rios", "Jamaica", 3, "Humid, lively" },
                    { 33, "Limon", "Costa Rica", 5, "Beautiful" },
                    { 34, "San Jose", "Costa Rica", 1, "Lots of people, lots to do" },
                    { 35, "Iquique", "Chile", 3, "Tons of buildings" },
                    { 36, "Pucon", "Chile", 2, "Big mountain" },
                    { 37, "Valparaiso", "Chile", 3, "Beach" },
                    { 38, "Osaka", "Japan", 2, "Cold. So cold" },
                    { 39, "Odesa", "Ukraine", 2, "A little scary. Old and cold" },
                    { 40, "Gothenburg", "Sweden", 4, "Nice bridge" },
                    { 41, "Stockholm", "Sweden", 1, "Expensive and snowy" },
                    { 42, "Kathmandu", "Nepal", 5, "Temples, spiritual" },
                    { 43, "Pokhara", "Nepal", 4, "Expansive natural views" },
                    { 44, "Batman", "Turkey", 3, "Great Bruce Wayne" },
                    { 45, "Istanbul", "Turkey", 2, "Historic, lots of sights to see" },
                    { 46, "Ulaanbaatar", "Mongolia", 3, "Most colorful flag" },
                    { 47, "St Petersburg", "Russia", 3, "Stark. Cold" },
                    { 48, "Moscow", "Russia", 2, "Vast" },
                    { 29, "Inn Wa", "Burma", 4, "Great food" },
                    { 49, "Kazan", "Russia", 5, "Blue Skies" },
                    { 28, "Juneau", "USA", 5, "The most beautiful place, ever" },
                    { 26, "Kyoto", "Japan", 5, "Cherry blossoms, temples, beautiful" },
                    { 7, "Bangkok", "Thailand", 4, "Humid, noisy, delicious food" },
                    { 8, "Tokyo", "Japan", 5, "Bright, bustling, exciting" },
                    { 9, "Berlin", "Germany", 4, "Excellent vegetarian options" },
                    { 10, "Ashgabat", "Turkmenistan", 2, "Dry, drought, rough" },
                    { 11, "Antananarivo", "Madagascar", 2, "High crime, politically unstable" },
                    { 12, "Brazzaville", "Congo", 2, "Beautiful but corrupt" },
                    { 13, "Melbourne", "Australia", 4, "Gorgeous with fantastic food" },
                    { 14, "Chicago", "USA", 4, "Windy, great pizza" },
                    { 15, "Vancouver", "Canada", 3, "Diverse, denim" },
                    { 16, "Glasgow", "Scotland", 3, "Bland food, gorgeous nature" },
                    { 17, "Mexico City", "Mexico", 4, "Bustling, bright, crowded" },
                    { 18, "Male", "Maldives", 3, "Tropical, prone to flooding" },
                    { 19, "Frankfurt", "Germany", 4, "Sausages everywhere" },
                    { 20, "Sao Paulo", "Brazil", 3, "Big. Good nightlife" },
                    { 21, "Guadalajara", "Mexico", 4, "Lots of markets, great food, good weather" },
                    { 22, "Puerto Vallarta", "Mexico", 3, "Beaches, resorts" },
                    { 23, "Munich", "Germany", 3, "Laderhosen" },
                    { 24, "Shanghai", "China", 3, "Insanely crowded, spicy food" },
                    { 25, "Xi'an", "China", 2, "Crowded" },
                    { 27, "Valletta", "Malta", 3, "Cool" },
                    { 50, "Tulum", "Mexico", 5, "Beaches, caves to explore" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "Rating",
                value: 5);
        }
    }
}
