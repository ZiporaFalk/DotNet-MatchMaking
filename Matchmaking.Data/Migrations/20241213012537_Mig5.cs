using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matchmaking.Data.Migrations
{
    public partial class Mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdM",
                table: "matches");

            migrationBuilder.RenameColumn(
                name: "MyMatch",
                table: "Resumes",
                newName: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_MatchId",
                table: "Resumes",
                column: "MatchId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_matches_MatchId",
                table: "Resumes",
                column: "MatchId",
                principalTable: "matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_matches_MatchId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_MatchId",
                table: "Resumes");

            migrationBuilder.RenameColumn(
                name: "MatchId",
                table: "Resumes",
                newName: "MyMatch");

            migrationBuilder.AddColumn<int>(
                name: "IdM",
                table: "matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
