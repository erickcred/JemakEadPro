using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class VideoCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Video",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Video_CursoId",
                table: "Video",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Curso",
                table: "Video",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Video_Curso",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Video_CursoId",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Video");
        }
    }
}
