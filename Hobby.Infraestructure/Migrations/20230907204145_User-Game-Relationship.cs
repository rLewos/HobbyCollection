using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class UserGameRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGame");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Users",
                newName: "dat_Updated");

            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "Users",
                newName: "nm_Nickname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "nm_User");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Users",
                newName: "ind_Active");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "dat_Created");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Publishers",
                newName: "dat_Updated");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Publishers",
                newName: "nm_Publisher");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Publishers",
                newName: "ind_Active");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Publishers",
                newName: "dat_Created");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Plataforms",
                newName: "dat_Updated");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Plataforms",
                newName: "nm_Plataform");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Plataforms",
                newName: "ind_Active");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Plataforms",
                newName: "dat_Created");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Developers",
                newName: "dat_Updated");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Developers",
                newName: "nm_Developer");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Developers",
                newName: "ind_Active");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Developers",
                newName: "dat_Created");

            migrationBuilder.AlterColumn<string>(
                name: "nm_Nickname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nm_User",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nm_Publisher",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nm_Plataform",
                table: "Plataforms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nm_Developer",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Tb_UserGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    HasBeaten = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_UserGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_UserGame_Tb_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Tb_Game",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tb_UserGame_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_UserGame_GameId",
                table: "Tb_UserGame",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_UserGame_UserId",
                table: "Tb_UserGame",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_UserGame");

            migrationBuilder.RenameColumn(
                name: "nm_User",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "nm_Nickname",
                table: "Users",
                newName: "Nickname");

            migrationBuilder.RenameColumn(
                name: "ind_Active",
                table: "Users",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "dat_Updated",
                table: "Users",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "dat_Created",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "nm_Publisher",
                table: "Publishers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ind_Active",
                table: "Publishers",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "dat_Updated",
                table: "Publishers",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "dat_Created",
                table: "Publishers",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "nm_Plataform",
                table: "Plataforms",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ind_Active",
                table: "Plataforms",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "dat_Updated",
                table: "Plataforms",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "dat_Created",
                table: "Plataforms",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "nm_Developer",
                table: "Developers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ind_Active",
                table: "Developers",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "dat_Updated",
                table: "Developers",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "dat_Created",
                table: "Developers",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nickname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publishers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Plataforms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "UserGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasBeaten = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGame_Tb_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Tb_Game",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserGame_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_GameId",
                table: "UserGame",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_UserId",
                table: "UserGame",
                column: "UserId");
        }
    }
}
