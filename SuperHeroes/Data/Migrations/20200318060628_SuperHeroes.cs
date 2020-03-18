using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroes.Data.Migrations
{
    public partial class SuperHeroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Super_Hero",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SuperHeroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "Super_Hero",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
