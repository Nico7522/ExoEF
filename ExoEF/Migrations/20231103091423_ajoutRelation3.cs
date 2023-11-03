using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class ajoutRelation3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorID",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "personId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Director_DirectorID",
                table: "Movies",
                column: "DirectorID",
                principalTable: "Director",
                principalColumn: "personId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Director_DirectorID",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "personId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorID",
                table: "Movies",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "personId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
