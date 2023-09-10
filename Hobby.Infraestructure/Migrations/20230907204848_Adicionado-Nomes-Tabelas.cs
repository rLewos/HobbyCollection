using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoNomesTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_GameDeveloper_Developers_DeveloperListId",
                table: "Tb_GameDeveloper");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_GamePlataform_Plataforms_PlataformListId",
                table: "Tb_GamePlataform");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_GamePublisher_Publishers_PublisherListId",
                table: "Tb_GamePublisher");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_UserGame_Users_UserId",
                table: "Tb_UserGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plataforms",
                table: "Plataforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Tb_User");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Tb_Publisher");

            migrationBuilder.RenameTable(
                name: "Plataforms",
                newName: "Tb_Plataform");

            migrationBuilder.RenameTable(
                name: "Developers",
                newName: "Tb_Developer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_User",
                table: "Tb_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Publisher",
                table: "Tb_Publisher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Plataform",
                table: "Tb_Plataform",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Developer",
                table: "Tb_Developer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_GameDeveloper_Tb_Developer_DeveloperListId",
                table: "Tb_GameDeveloper",
                column: "DeveloperListId",
                principalTable: "Tb_Developer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_GamePlataform_Tb_Plataform_PlataformListId",
                table: "Tb_GamePlataform",
                column: "PlataformListId",
                principalTable: "Tb_Plataform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_GamePublisher_Tb_Publisher_PublisherListId",
                table: "Tb_GamePublisher",
                column: "PublisherListId",
                principalTable: "Tb_Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_UserGame_Tb_User_UserId",
                table: "Tb_UserGame",
                column: "UserId",
                principalTable: "Tb_User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_GameDeveloper_Tb_Developer_DeveloperListId",
                table: "Tb_GameDeveloper");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_GamePlataform_Tb_Plataform_PlataformListId",
                table: "Tb_GamePlataform");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_GamePublisher_Tb_Publisher_PublisherListId",
                table: "Tb_GamePublisher");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_UserGame_Tb_User_UserId",
                table: "Tb_UserGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_User",
                table: "Tb_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Publisher",
                table: "Tb_Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Plataform",
                table: "Tb_Plataform");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Developer",
                table: "Tb_Developer");

            migrationBuilder.RenameTable(
                name: "Tb_User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Tb_Publisher",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "Tb_Plataform",
                newName: "Plataforms");

            migrationBuilder.RenameTable(
                name: "Tb_Developer",
                newName: "Developers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plataforms",
                table: "Plataforms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_GameDeveloper_Developers_DeveloperListId",
                table: "Tb_GameDeveloper",
                column: "DeveloperListId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_GamePlataform_Plataforms_PlataformListId",
                table: "Tb_GamePlataform",
                column: "PlataformListId",
                principalTable: "Plataforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_GamePublisher_Publishers_PublisherListId",
                table: "Tb_GamePublisher",
                column: "PublisherListId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_UserGame_Users_UserId",
                table: "Tb_UserGame",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
