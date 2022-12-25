using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class IncioVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Iniciado",
                table: "Video",
                type: "BOOL",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iniciado",
                table: "Video");
        }
    }
}
