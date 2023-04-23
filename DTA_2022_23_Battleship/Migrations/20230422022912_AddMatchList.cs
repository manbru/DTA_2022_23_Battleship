using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTA_2022_23_Battleship.Migrations
{
    /// <inheritdoc />
    public partial class AddMatchList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_LoserUserId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_WinnerUserId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_LoserUserId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerUserId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "WinnerUserId",
                table: "Matches",
                newName: "WinnerScore");

            migrationBuilder.RenameColumn(
                name: "LoserUserId",
                table: "Matches",
                newName: "LoserScore");

            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LoserName",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Matches",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinnerName",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserId",
                table: "Matches",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_UserId",
                table: "Matches",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_UserId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_UserId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoserName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerName",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "WinnerScore",
                table: "Matches",
                newName: "WinnerUserId");

            migrationBuilder.RenameColumn(
                name: "LoserScore",
                table: "Matches",
                newName: "LoserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LoserUserId",
                table: "Matches",
                column: "LoserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerUserId",
                table: "Matches",
                column: "WinnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_LoserUserId",
                table: "Matches",
                column: "LoserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_WinnerUserId",
                table: "Matches",
                column: "WinnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
