using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLesson.Migrations
{
    public partial class semesteryearadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "Letters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Letters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Letters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Letters");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Letters");
        }
    }
}
