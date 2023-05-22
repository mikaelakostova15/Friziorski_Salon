using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friziorski_Salon.Migrations
{
    public partial class ikms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegisterOn",
                table: "AspNetUsers");
        }
    }
}
