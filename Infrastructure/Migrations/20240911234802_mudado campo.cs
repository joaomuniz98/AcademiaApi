using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class mudadocampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "UsersProfiles",
                type: "VARCHAR(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "UsersProfiles",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "UsersProfiles",
                type: "VARCHAR(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "UsersProfiles",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "UsersProfiles",
                type: "VARCHAR(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "UsersProfiles",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "UsersProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "UsersProfiles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "UsersProfiles",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "UsersProfiles",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(14)");
        }
    }
}
