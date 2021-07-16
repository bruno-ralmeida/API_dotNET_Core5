using Microsoft.EntityFrameworkCore.Migrations;

namespace csharp_apiRest.Migrations
{
    public partial class UpdateMovieMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Movies",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
