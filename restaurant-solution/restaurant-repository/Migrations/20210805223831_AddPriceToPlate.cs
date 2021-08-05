using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Repository.Migrations
{
    public partial class AddPriceToPlate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Plates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice",
                table: "Plates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Plates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Plates");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Plates");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Plates");
        }
    }
}
