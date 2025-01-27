﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtorsSystem.Migrations
{
    public partial class addnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Debtors",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Debtors");
        }
    }
}
