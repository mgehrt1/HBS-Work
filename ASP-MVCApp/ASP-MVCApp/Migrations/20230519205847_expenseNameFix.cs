using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_MVCApp.Migrations
{
    public partial class expenseNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Expenses",
                newName: "ExpenseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseName",
                table: "Expenses",
                newName: "ItemName");
        }
    }
}
