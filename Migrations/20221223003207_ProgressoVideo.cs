using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class ProgressoVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finalizado",
                table: "Video",
                type: "BOOL",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Progresso",
                table: "Video",
                type: "VARCHAR(3)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finalizado",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "Progresso",
                table: "Video");
        }
    }
}
