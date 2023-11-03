using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExoEF.Migrations
{
    public partial class allez2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 7 });
        }
    }
}
