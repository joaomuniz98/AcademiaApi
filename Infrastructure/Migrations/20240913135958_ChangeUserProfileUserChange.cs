using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class ChangeUserProfileUserChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersCredentials_UsersProfiles_UserId",
                table: "UsersCredentials");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCredentials_UsersProfiles_UserId",
                table: "UsersCredentials",
                column: "UserId",
                principalTable: "UsersProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersCredentials_UsersProfiles_UserId",
                table: "UsersCredentials");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCredentials_UsersProfiles_UserId",
                table: "UsersCredentials",
                column: "UserId",
                principalTable: "UsersProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
