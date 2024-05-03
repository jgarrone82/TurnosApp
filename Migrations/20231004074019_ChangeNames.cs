using Microsoft.EntityFrameworkCore.Migrations;

namespace TurnosApp.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripction",
                table: "Specialties");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Specialties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Specialties");

            migrationBuilder.AddColumn<string>(
                name: "Descripction",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
