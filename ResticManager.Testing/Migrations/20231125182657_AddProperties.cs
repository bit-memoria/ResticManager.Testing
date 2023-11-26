using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResticManager.Testing.Migrations
{
    /// <inheritdoc />
    public partial class AddProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompressionProgress",
                table: "ResticSnapshots",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Hostname",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Original",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parent",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paths",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProgramVersion",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "ResticSnapshots",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompressionProgress",
                table: "Repositories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompressionProgress",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Hostname",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Original",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Parent",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Paths",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "ProgramVersion",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "ResticSnapshots");

            migrationBuilder.DropColumn(
                name: "CompressionProgress",
                table: "Repositories");
        }
    }
}
