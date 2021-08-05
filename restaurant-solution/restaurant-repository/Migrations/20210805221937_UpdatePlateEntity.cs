using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Repository.Migrations
{
    public partial class UpdatePlateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Plates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Plates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Plates");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Plates");
        }
    }
}
