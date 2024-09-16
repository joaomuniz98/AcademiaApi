using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddRelaton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameRole = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "Datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "UsersInRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersInRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersInRoles_UsersCredentials_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersCredentials",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_NameRole",
                table: "Roles",
                column: "NameRole",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersInRoles_RoleId",
                table: "UsersInRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInRoles_UserId",
                table: "UsersInRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersInRoles");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
