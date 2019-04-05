using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtorsSystem.Migrations
{
    public partial class sync1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotificationExecution",
                table: "Debtors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotificationRefund",
                table: "Debtors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotificationTrial",
                table: "Debtors",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationExecution",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "NotificationRefund",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "NotificationTrial",
                table: "Debtors");
        }
    }
}
