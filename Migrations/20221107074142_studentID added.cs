using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLesson.Migrations
{
    public partial class studentIDadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Letters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Letters");
        }
    }
}
