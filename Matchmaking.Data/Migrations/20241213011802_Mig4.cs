using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matchmaking.Data.Migrations
{
    public partial class Mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_matches_MyMatchId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_MyMatchId",
                table: "Resumes");

            migrationBuilder.RenameColumn(
                name: "MyMatchId",
                table: "Resumes",
                newName: "MyMatch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyMatch",
                table: "Resumes",
                newName: "MyMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_MyMatchId",
                table: "Resumes",
                column: "MyMatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_matches_MyMatchId",
                table: "Resumes",
                column: "MyMatchId",
                principalTable: "matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
