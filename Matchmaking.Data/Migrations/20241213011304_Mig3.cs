using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matchmaking.Data.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meetings_matches_MatchId",
                table: "meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_meetings_matchmakers_MatchMakerId",
                table: "meetings");

            migrationBuilder.DropIndex(
                name: "IX_meetings_MatchMakerId",
                table: "meetings");

            migrationBuilder.DropColumn(
                name: "IdF",
                table: "meetings");

            migrationBuilder.DropColumn(
                name: "IdM",
                table: "meetings");

            migrationBuilder.DropColumn(
                name: "MatchMakerId",
                table: "meetings");

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "meetings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_meetings_matches_MatchId",
                table: "meetings",
                column: "MatchId",
                principalTable: "matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meetings_matches_MatchId",
                table: "meetings");

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "meetings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdF",
                table: "meetings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdM",
                table: "meetings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MatchMakerId",
                table: "meetings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_meetings_MatchMakerId",
                table: "meetings",
                column: "MatchMakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_meetings_matches_MatchId",
                table: "meetings",
                column: "MatchId",
                principalTable: "matches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_meetings_matchmakers_MatchMakerId",
                table: "meetings",
                column: "MatchMakerId",
                principalTable: "matchmakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
