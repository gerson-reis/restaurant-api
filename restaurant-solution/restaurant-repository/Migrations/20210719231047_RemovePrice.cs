using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Repository.Migrations
{
    public partial class RemovePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Plates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Plates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
