using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class retest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Director_DirectorID",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

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

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "personId");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorID", "Genre", "Title", "YearRelease" },
                values: new object[,]
                {
                    { 1, 1, "Science-Fiction", "Star Wars : Un nouvel espoir", 1977 },
                    { 2, 1, "Science-Fiction", "Star Wars : L'empire contre-attaque", 1980 },
                    { 3, 1, "Science-Fiction", "Star Wars : Le retour du Jedi", 1983 },
                    { 4, 1, "Société", "Hooligans", 2005 },
                    { 5, 1, "Heroic-Fantasy", "LOTR - La communauté de l'anneau", 2001 },
                    { 6, 1, "Heroic-Fantasy", "LOTR - Les deux tours", 2002 },
                    { 7, 1, "Heroic-Fantasy", "LOTR - Le retour du roi", 2003 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorID",
                table: "Movies",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "personId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorID",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

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

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "personId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Director_DirectorID",
                table: "Movies",
                column: "DirectorID",
                principalTable: "Director",
                principalColumn: "personId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
