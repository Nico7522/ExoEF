using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class ajoutRelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorFilmpersonId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "DirectorFilmpersonId",
                table: "Movies",
                newName: "DirectorID");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_DirectorFilmpersonId",
                table: "Movies",
                newName: "IX_Movies_DirectorID");

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

            migrationBuilder.RenameColumn(
                name: "DirectorID",
                table: "Movies",
                newName: "DirectorFilmpersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_DirectorID",
                table: "Movies",
                newName: "IX_Movies_DirectorFilmpersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorFilmpersonId",
                table: "Movies",
                column: "DirectorFilmpersonId",
                principalTable: "Directors",
                principalColumn: "personId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
