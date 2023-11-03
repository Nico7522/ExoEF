using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class ajoutDatarel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "personId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Arnold", "Schwarzenegger" },
                    { 2, "Kate", "Winslet" },
                    { 3, "Leonardo", "DiCaprio" },
                    { 4, "Meryl", "Streep" },
                    { 5, "Johnny", "Depp" },
                    { 6, "Angelina", "Jolie" },
                    { 7, "Brad", "Pitt" },
                    { 8, "Tom", "Cruise" },
                    { 9, "Natalie", "Portman" },
                    { 10, "Tom", "Hanks" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "personId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Steven", "Spielberg" },
                    { 2, "Quentin", "Tarantino" },
                    { 3, "Christopher", "Nolan" },
                    { 4, "Kathryn", "Bigelow" },
                    { 5, "Martin", "Scorsese" },
                    { 6, "Francis Ford", "Coppola" },
                    { 7, "Paul Thomas", "Anderson" },
                    { 8, "Spike", "Lee" },
                    { 9, "Denis", "Villeneuve" },
                    { 10, "Joel and Ethan", "Coen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "personId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "personId",
                keyValue: 10);
        }
    }
}
