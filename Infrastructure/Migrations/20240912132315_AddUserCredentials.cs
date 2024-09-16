using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddUserCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    password_hash = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    password_reset_token = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    password_reset_expires = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    last_login = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Credentials_UsersProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credentials");
        }
    }
}
