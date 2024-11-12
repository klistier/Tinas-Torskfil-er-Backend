﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinas_Torskfiléer_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedLowStockField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LowStockWarning",
                table: "TinasProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LowStockWarning",
                table: "TinasProducts");
        }
    }
}
