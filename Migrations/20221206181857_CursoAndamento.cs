using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CursoAndamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Andamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Andamento_CursoId",
                table: "Andamento",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Andamento_Curso",
                table: "Andamento",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Andamento_Curso",
                table: "Andamento");

            migrationBuilder.DropIndex(
                name: "IX_Andamento_CursoId",
                table: "Andamento");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Andamento");
        }
    }
}
