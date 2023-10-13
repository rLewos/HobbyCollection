using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class ValueGeneratedGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Developer",
                columns: table => new
                {
                    id_Developer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_Active = table.Column<bool>(type: "bit", nullable: false),
                    dat_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.id_Developer);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Game",
                columns: table => new
                {
                    id_Game = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_Game = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dat_Release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_Active = table.Column<bool>(type: "bit", nullable: false),
                    dat_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.id_Game);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Plataform",
                columns: table => new
                {
                    id_Plataform = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_Plataform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_Active = table.Column<bool>(type: "bit", nullable: false),
                    dat_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataform", x => x.id_Plataform);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Publisher",
                columns: table => new
                {
                    id_Publisher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_Active = table.Column<bool>(type: "bit", nullable: false),
                    dat_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.id_Publisher);
                });

            migrationBuilder.CreateTable(
                name: "Tb_User",
                columns: table => new
                {
                    id_User = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nm_Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_Active = table.Column<bool>(type: "bit", nullable: false),
                    dat_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dat_Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id_User);
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
                        name: "FK_Tb_GameDeveloper_Tb_Developer_DeveloperListId",
                        column: x => x.DeveloperListId,
                        principalTable: "Tb_Developer",
                        principalColumn: "id_Developer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_GameDeveloper_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "id_Game",
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
                        name: "FK_Tb_GamePlataform_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "id_Game",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_GamePlataform_Tb_Plataform_PlataformListId",
                        column: x => x.PlataformListId,
                        principalTable: "Tb_Plataform",
                        principalColumn: "id_Plataform",
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
                        name: "FK_Tb_GamePublisher_Tb_Game_GameListId",
                        column: x => x.GameListId,
                        principalTable: "Tb_Game",
                        principalColumn: "id_Game",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_GamePublisher_Tb_Publisher_PublisherListId",
                        column: x => x.PublisherListId,
                        principalTable: "Tb_Publisher",
                        principalColumn: "id_Publisher",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_UserGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    has_Beaten = table.Column<bool>(type: "bit", nullable: false),
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
                        principalColumn: "id_Game");
                    table.ForeignKey(
                        name: "FK_Tb_UserGame_Tb_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Tb_User",
                        principalColumn: "id_User");
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
                name: "Tb_GameDeveloper");

            migrationBuilder.DropTable(
                name: "Tb_GamePlataform");

            migrationBuilder.DropTable(
                name: "Tb_GamePublisher");

            migrationBuilder.DropTable(
                name: "Tb_UserGame");

            migrationBuilder.DropTable(
                name: "Tb_Developer");

            migrationBuilder.DropTable(
                name: "Tb_Plataform");

            migrationBuilder.DropTable(
                name: "Tb_Publisher");

            migrationBuilder.DropTable(
                name: "Tb_Game");

            migrationBuilder.DropTable(
                name: "Tb_User");
        }
    }
}
