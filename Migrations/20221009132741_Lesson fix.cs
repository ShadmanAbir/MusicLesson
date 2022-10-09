using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLesson.Migrations
{
    public partial class Lessonfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "TermStartDate",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Letters");

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<DateTime>(
                name: "TermStartDate",
                table: "Lessons",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Lessons",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "TermStartDate",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Lessons");

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "Letters",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Letters",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<DateTime>(
                name: "TermStartDate",
                table: "Letters",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Letters",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 10);
        }
    }
}
