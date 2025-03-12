using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedUserFromGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_User_Tb_Game_GameId",
                table: "Tb_User");

            migrationBuilder.DropIndex(
                name: "IX_Tb_User_GameId",
                table: "Tb_User");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Tb_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Tb_User",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_GameId",
                table: "Tb_User",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_User_Tb_Game_GameId",
                table: "Tb_User",
                column: "GameId",
                principalTable: "Tb_Game",
                principalColumn: "id_Game");
        }
    }
}
