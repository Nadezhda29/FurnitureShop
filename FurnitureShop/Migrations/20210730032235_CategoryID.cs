using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureShop.Migrations
{
    public partial class CategoryID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "TypeFurniture",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "TypeFurniture");
        }
    }
}
