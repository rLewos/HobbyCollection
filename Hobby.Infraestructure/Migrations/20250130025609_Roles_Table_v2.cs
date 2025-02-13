using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hobby.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class Roles_Table_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Role",
                columns: table => new
                {
                    id_Roles = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nm_User = table.Column<string>(type: "text", nullable: false),
                    is_Active = table.Column<bool>(type: "boolean", nullable: false),
                    dt_Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dt_Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id_Roles);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Role");
        }
    }
}
