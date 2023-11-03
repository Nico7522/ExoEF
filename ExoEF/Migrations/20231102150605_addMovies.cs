using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class addMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Actor", "Director", "Genre", "Title", "YearRelease" },
                values: new object[] { "Mark Hammil", "Georges Lucas", "Science-Fiction", "Star Wars : Un nouvel espoir", 1977 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Actor", "Director", "Genre", "Title", "YearRelease" },
                values: new object[,]
                {
                    { 2, "Mark Hammil", "Georges Lucas", "Science-Fiction", "Star Wars : L'empire contre-attaque", 1980 },
                    { 3, "Mark Hammil", "Georges Lucas", "Science-Fiction", "Star Wars : Le retour du Jedi", 1983 },
                    { 4, "Charlie Hunnam", "Lexi Alexander", "Société", "Hooligans", 2005 },
                    { 5, "Elijah Wood", "Peter Jackson", "Heroic-Fantasy", "LOTR - La communauté de l'anneau", 2001 },
                    { 6, "Elijah Wood", "Peter Jackson", "Heroic-Fantasy", "LOTR - Les deux tours", 2002 },
                    { 7, "Elijah Wood", "Peter Jackson", "Heroic-Fantasy", "LOTR - Le retour du roi", 2003 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Actor", "Director", "Genre", "Title", "YearRelease" },
                values: new object[] { "Schw", "director", "Action", "Terminator", 1980 });
        }
    }
}
