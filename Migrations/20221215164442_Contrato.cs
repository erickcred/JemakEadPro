using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class Contrato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContratoId",
                table: "Curso",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: true),
                    DataMatricula = table.Column<DateTime>(nullable: false),
                    DataEncerramento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrato_Usuario_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_ContratoId",
                table: "Curso",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_AlunoId",
                table: "Contrato",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Contrato",
                table: "Curso",
                column: "ContratoId",
                principalTable: "Contrato",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Contrato",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropIndex(
                name: "IX_Curso_ContratoId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "ContratoId",
                table: "Curso");
        }
    }
}
