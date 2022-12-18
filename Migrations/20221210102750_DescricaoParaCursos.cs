using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class DescricaoParaCursos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcessoIlimitado",
                table: "Curso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Atencao",
                table: "Curso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Curso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstruturaDoCurso",
                table: "Curso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Excelencia",
                table: "Curso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metodologia",
                table: "Curso",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Objetivo",
                table: "Curso",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcessoIlimitado",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Atencao",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "EstruturaDoCurso",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Excelencia",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Metodologia",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Objetivo",
                table: "Curso");
        }
    }
}
