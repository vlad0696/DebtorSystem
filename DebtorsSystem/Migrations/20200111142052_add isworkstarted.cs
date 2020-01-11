using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtorsSystem.Migrations
{
    public partial class addisworkstarted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsWorkStarted",
                table: "Debtors",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsWorkStarted",
                table: "Debtors");
        }
    }
}
