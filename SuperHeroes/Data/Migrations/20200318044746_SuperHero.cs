using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroes.Data.Migrations
{
    public partial class SuperHero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alterEgo",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "catchPhrase",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "mainPower",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "secondaryPower",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "superHeroName",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "Alter_Ego",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Catch_Phrase",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Main_Power",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Secondary_Power",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Super_Hero",
                table: "SuperHeroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alter_Ego",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Catch_Phrase",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Main_Power",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Secondary_Power",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Super_Hero",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "alterEgo",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "catchPhrase",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mainPower",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "secondaryPower",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "superHeroName",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
