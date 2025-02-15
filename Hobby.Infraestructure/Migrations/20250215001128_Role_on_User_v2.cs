using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Role_on_User_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_roles",
                table: "Tb_User",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_User_id_roles",
                table: "Tb_User",
                column: "id_roles");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_User_Tb_Role_id_roles",
                table: "Tb_User",
                column: "id_roles",
                principalTable: "Tb_Role",
                principalColumn: "id_Roles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_User_Tb_Role_id_roles",
                table: "Tb_User");

            migrationBuilder.DropIndex(
                name: "IX_Tb_User_id_roles",
                table: "Tb_User");

            migrationBuilder.DropColumn(
                name: "id_roles",
                table: "Tb_User");
        }
    }
}
