using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matchmaking.Data.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdMatchMaker",
                table: "meetings",
                newName: "MatchMakerId");

            migrationBuilder.AddColumn<int>(
                name: "MyMatchId",
                table: "Resumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "meetings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchMakerId = table.Column<int>(type: "int", nullable: false),
                    IdM = table.Column<int>(type: "int", nullable: false),
                    IdF = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_matches_matchmakers_MatchMakerId",
                        column: x => x.MatchMakerId,
                        principalTable: "matchmakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_MyMatchId",
                table: "Resumes",
                column: "MyMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_meetings_MatchId",
                table: "meetings",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_meetings_MatchMakerId",
                table: "meetings",
                column: "MatchMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_matches_MatchMakerId",
                table: "matches",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_matches_MyMatchId",
                table: "Resumes",
                column: "MyMatchId",
                principalTable: "matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_meetings_matches_MatchId",
                table: "meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_meetings_matchmakers_MatchMakerId",
                table: "meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_matches_MyMatchId",
                table: "Resumes");

            migrationBuilder.DropTable(
                name: "matches");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_MyMatchId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_meetings_MatchId",
                table: "meetings");

            migrationBuilder.DropIndex(
                name: "IX_meetings_MatchMakerId",
                table: "meetings");

            migrationBuilder.DropColumn(
                name: "MyMatchId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "meetings");

            migrationBuilder.RenameColumn(
                name: "MatchMakerId",
                table: "meetings",
                newName: "IdMatchMaker");
        }
    }
}
