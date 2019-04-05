using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtorsSystem.Migrations
{
    public partial class addNotidicationsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NotificationViewExecution",
                table: "Debtors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotificationViewRefund",
                table: "Debtors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotificationViewTrial",
                table: "Debtors",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationViewExecution",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "NotificationViewRefund",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "NotificationViewTrial",
                table: "Debtors");
        }
    }
}
