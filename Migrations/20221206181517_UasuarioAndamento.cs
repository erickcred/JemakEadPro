using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class UasuarioAndamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Andamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Andamento_UsuarioId",
                table: "Andamento",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Andamento_Usuario",
                table: "Andamento",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Andamento_Usuario",
                table: "Andamento");

            migrationBuilder.DropIndex(
                name: "IX_Andamento_UsuarioId",
                table: "Andamento");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Andamento");
        }
    }
}
