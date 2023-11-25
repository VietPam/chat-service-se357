﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chat_service_se357.Migrations
{
    public partial class _117 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "avatar",
                table: "tb_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "tb_user",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
