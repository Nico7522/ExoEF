using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class allez : Migration
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
        }
    }
}
