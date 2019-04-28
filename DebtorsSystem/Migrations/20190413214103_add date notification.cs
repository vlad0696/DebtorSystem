using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtorsSystem.Migrations
{
    public partial class adddatenotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateNotificationExecution",
                table: "Debtors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateNotificationRefund",
                table: "Debtors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateNotificationTrial",
                table: "Debtors",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateNotificationExecution",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "DateNotificationRefund",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "DateNotificationTrial",
                table: "Debtors");
        }
    }
}
