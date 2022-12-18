using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class MaterialCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Material",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Material_CursoId",
                table: "Material",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Curso",
                table: "Material",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Curso",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_CursoId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Material");
        }
    }
}
