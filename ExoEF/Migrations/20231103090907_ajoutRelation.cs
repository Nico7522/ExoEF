using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class ajoutRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Actor",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "DirectorFilmpersonId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    personId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.personId);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    personId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.personId);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "personId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorFilmpersonId",
                table: "Movies",
                column: "DirectorFilmpersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorFilmpersonId",
                table: "Movies",
                column: "DirectorFilmpersonId",
                principalTable: "Directors",
                principalColumn: "personId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorFilmpersonId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Movies_DirectorFilmpersonId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "DirectorFilmpersonId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Actor",
                table: "Movies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Actor", "Director", "Genre", "Title", "YearRelease" },
                values: new object[,]
                {
                    { 1, "Mark Hammil", "Georges Lucas", "Science-Fiction", "Star Wars : Un nouvel espoir", 1977 },
                    { 2, "Mark Hammil", "Georges Lucas", "Science-Fiction", "Star Wars : L'empire contre-attaque", 1980 },
                    { 3, "Mark Hammil", "Georges Lucas", "Science-Fiction", "Star Wars : Le retour du Jedi", 1983 },
                    { 4, "Charlie Hunnam", "Lexi Alexander", "Société", "Hooligans", 2005 },
                    { 5, "Elijah Wood", "Peter Jackson", "Heroic-Fantasy", "LOTR - La communauté de l'anneau", 2001 },
                    { 6, "Elijah Wood", "Peter Jackson", "Heroic-Fantasy", "LOTR - Les deux tours", 2002 },
                    { 7, "Elijah Wood", "Peter Jackson", "Heroic-Fantasy", "LOTR - Le retour du roi", 2003 }
                });
        }
    }
}
