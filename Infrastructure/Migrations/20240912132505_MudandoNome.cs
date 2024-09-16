using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class MudandoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credentials_UsersProfiles_UserId",
                table: "Credentials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Credentials",
                table: "Credentials");

            migrationBuilder.RenameTable(
                name: "Credentials",
                newName: "UsersCredentials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersCredentials",
                table: "UsersCredentials",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCredentials_UsersProfiles_UserId",
                table: "UsersCredentials",
                column: "UserId",
                principalTable: "UsersProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersCredentials_UsersProfiles_UserId",
                table: "UsersCredentials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersCredentials",
                table: "UsersCredentials");

            migrationBuilder.RenameTable(
                name: "UsersCredentials",
                newName: "Credentials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Credentials",
                table: "Credentials",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Credentials_UsersProfiles_UserId",
                table: "Credentials",
                column: "UserId",
                principalTable: "UsersProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
