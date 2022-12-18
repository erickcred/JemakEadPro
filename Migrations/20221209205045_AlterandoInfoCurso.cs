using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class AlterandoInfoCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataValidarCRC",
                table: "Curso",
                newName: "DataSubmicaoCRC");

            migrationBuilder.RenameColumn(
                name: "CodigoCRC",
                table: "Curso",
                newName: "CodigoCursoCRC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataSubmicaoCRC",
                table: "Curso",
                newName: "DataValidarCRC");

            migrationBuilder.RenameColumn(
                name: "CodigoCursoCRC",
                table: "Curso",
                newName: "CodigoCRC");
        }
    }
}
