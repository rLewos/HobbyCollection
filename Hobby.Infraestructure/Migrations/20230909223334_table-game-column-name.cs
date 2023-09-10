using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Games.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class tablegamecolumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "cod_Game",
                table: "Tb_Game");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tb_Game",
                newName: "cod_Game");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Tb_Game",
                column: "cod_Game");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Tb_Game");

            migrationBuilder.RenameColumn(
                name: "cod_Game",
                table: "Tb_Game",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "cod_Game",
                table: "Tb_Game",
                column: "Id");
        }
    }
}
