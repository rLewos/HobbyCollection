using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plataforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_Game = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dat_Release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ind_Active = table.Column<bool>(type: "bit", nullable: false),
                    dat_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cod_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_GameDeveloper",
                columns: table => new
                {
                    DeveloperListId = table.Column<int>(type: "int", nullable: false),
                    GameListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_GameDeveloper", x => new { x.DeveloperListId, x.GameListId });
                    table.ForeignKey(
                        name: "FK_Tb_GameDeveloper_Developers_DeveloperListId",
                        column: x => x.DeveloperListId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_GameDeveloper_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_GamePlataform",
                columns: table => new
                {
                    GameListId = table.Column<int>(type: "int", nullable: false),
                    PlataformListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_GamePlataform", x => new { x.GameListId, x.PlataformListId });
                    table.ForeignKey(
                        name: "FK_Tb_GamePlataform_Plataforms_PlataformListId",
                        column: x => x.PlataformListId,
                        principalTable: "Plataforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_GamePlataform_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_GamePublisher",
                columns: table => new
                {
                    GameListId = table.Column<int>(type: "int", nullable: false),
                    PublisherListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_GamePublisher", x => new { x.GameListId, x.PublisherListId });
                    table.ForeignKey(
                        name: "FK_Tb_GamePublisher_Publishers_PublisherListId",
                        column: x => x.PublisherListId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_GamePublisher_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGame",
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
                name: "IX_Tb_GameDeveloper_GameListId",
                table: "Tb_GameDeveloper",
                column: "GameListId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_GamePlataform_PlataformListId",
                table: "Tb_GamePlataform",
                column: "PlataformListId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_GamePublisher_PublisherListId",
                table: "Tb_GamePublisher",
                column: "PublisherListId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_GameId",
                table: "UserGame",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_UserId",
                table: "UserGame",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_GameDeveloper");

            migrationBuilder.DropTable(
                name: "Tb_GamePlataform");

            migrationBuilder.DropTable(
                name: "Tb_GamePublisher");

            migrationBuilder.DropTable(
                name: "UserGame");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Plataforms");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Tb_Game");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
