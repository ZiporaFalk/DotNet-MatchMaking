using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matchmaking.Data.Migrations
{
    public partial class Mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "matches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
