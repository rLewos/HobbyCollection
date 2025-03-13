using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class UserGameMapped : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_UserGame_Tb_Game_GameId",
                table: "Tb_UserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_UserGame_Tb_User_UserId",
                table: "Tb_UserGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_UserGame",
                table: "Tb_UserGame");

            migrationBuilder.DropIndex(
                name: "IX_Tb_UserGame_UserId",
                table: "Tb_UserGame");

            migrationBuilder.RenameColumn(
                name: "has_Beaten",
                table: "Tb_UserGame",
                newName: "has_beaten");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tb_UserGame",
                newName: "cd_user_id");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Tb_UserGame",
                newName: "cd_game_id");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_UserGame_GameId",
                table: "Tb_UserGame",
                newName: "IX_Tb_UserGame_cd_game_id");

            migrationBuilder.AlterColumn<bool>(
                name: "has_beaten",
                table: "Tb_UserGame",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tb_UserGame",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "cd_user_id",
                table: "Tb_UserGame",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cd_game_id",
                table: "Tb_UserGame",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_UserGame",
                table: "Tb_UserGame",
                columns: new[] { "cd_user_id", "cd_game_id" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_UserGame_Tb_Game_cd_game_id",
                table: "Tb_UserGame",
                column: "cd_game_id",
                principalTable: "Tb_Game",
                principalColumn: "id_Game",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_UserGame_Tb_User_cd_user_id",
                table: "Tb_UserGame",
                column: "cd_user_id",
                principalTable: "Tb_User",
                principalColumn: "id_User",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_UserGame_Tb_Game_cd_game_id",
                table: "Tb_UserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_UserGame_Tb_User_cd_user_id",
                table: "Tb_UserGame");

            migrationBuilder.DropTable(
                name: "GameUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_UserGame",
                table: "Tb_UserGame");

            migrationBuilder.RenameColumn(
                name: "has_beaten",
                table: "Tb_UserGame",
                newName: "has_Beaten");

            migrationBuilder.RenameColumn(
                name: "cd_game_id",
                table: "Tb_UserGame",
                newName: "GameId");

            migrationBuilder.RenameColumn(
                name: "cd_user_id",
                table: "Tb_UserGame",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_UserGame_cd_game_id",
                table: "Tb_UserGame",
                newName: "IX_Tb_UserGame_GameId");

            migrationBuilder.AlterColumn<bool>(
                name: "has_Beaten",
                table: "Tb_UserGame",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tb_UserGame",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Tb_UserGame",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Tb_UserGame",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_UserGame",
                table: "Tb_UserGame",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_UserGame_UserId",
                table: "Tb_UserGame",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_UserGame_Tb_Game_GameId",
                table: "Tb_UserGame",
                column: "GameId",
                principalTable: "Tb_Game",
                principalColumn: "id_Game");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_UserGame_Tb_User_UserId",
                table: "Tb_UserGame",
                column: "UserId",
                principalTable: "Tb_User",
                principalColumn: "id_User");
        }
    }
}
