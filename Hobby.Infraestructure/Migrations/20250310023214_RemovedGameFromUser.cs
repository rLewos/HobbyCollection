using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedGameFromUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameUser");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Tb_UserGame",
                newName: "dat_updated");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Tb_UserGame",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Tb_UserGame",
                newName: "dat_created");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Tb_UserGame",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "dat_updated",
                table: "Tb_UserGame",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "dat_created",
                table: "Tb_UserGame",
                newName: "CreatedDate");

            migrationBuilder.CreateTable(
                name: "GameUser",
                columns: table => new
                {
                    GameListId = table.Column<int>(type: "integer", nullable: false),
                    UserListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameUser", x => new { x.GameListId, x.UserListId });
                    table.ForeignKey(
                        name: "FK_GameUser_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "id_Game",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameUser_Tb_User_UserListId",
                        column: x => x.UserListId,
                        principalTable: "Tb_User",
                        principalColumn: "id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameUser_UserListId",
                table: "GameUser",
                column: "UserListId");
        }
    }
}
