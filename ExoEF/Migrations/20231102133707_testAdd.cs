using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class testAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Actor", "Director", "ReleaseDate", "Title" },
                values: new object[] { 1, "Schw", "director", new DateTime(1978, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);
        }
    }
}
