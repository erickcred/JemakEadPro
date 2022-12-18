using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CriandoCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Imagem = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Situacao = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Categoria = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CargaHoraria = table.Column<int>(type: "INT(10)", nullable: false),
                    Professor = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    DataValidarCRC = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataVencimentoCRC = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TurmaCRC = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CodigoCRC = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CategoriasPontuacao = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Pontos = table.Column<int>(type: "INT(10)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "Ix_Curso_Nome",
                table: "Curso",
                column: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
