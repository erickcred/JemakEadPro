using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CursoDadosProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjetoId",
                table: "Curso",
                type: "INT(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjetoPlayerKey",
                table: "Curso",
                type: "VARCHAR(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjetoToken",
                table: "Curso",
                type: "VARCHAR(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjetoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "ProjetoPlayerKey",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "ProjetoToken",
                table: "Curso");
        }
    }
}
