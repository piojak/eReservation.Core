using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DTO.Migrations
{
    public partial class RoomAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Rooms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caption",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Rooms");
        }
    }
}
