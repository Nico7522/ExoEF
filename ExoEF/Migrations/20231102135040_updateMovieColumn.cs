using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class updateMovieColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_ReleaseDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "YearRelease",
                table: "Movies",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "Genre", "YearRelease" },
                values: new object[] { "Action", 1980 });

            migrationBuilder.AddCheckConstraint(
                name: "CK_YearRelease",
                table: "Movies",
                sql: "YearRelease > 1975");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_YearRelease",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "YearRelease",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                maxLength: 100,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(1978, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddCheckConstraint(
                name: "CK_ReleaseDate",
                table: "Movies",
                sql: "YEAR(ReleaseDate) > 1975");
        }
    }
}
