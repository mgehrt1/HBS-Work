using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_MVCApp.Migrations
{
    public partial class addLenderAItemNameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Item");
        }
    }
}
