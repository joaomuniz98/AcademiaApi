using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class jj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProfiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersProfiles");
        }
    }
}
