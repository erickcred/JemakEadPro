using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CorrecaoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoUsuario",
                table: "Usuario",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ResponsavelTelefone",
                table: "Usuario",
                type: "VARCHAR(13)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(12)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoUsuario",
                table: "Usuario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "ResponsavelTelefone",
                table: "Usuario",
                type: "VARCHAR(12)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(13)",
                oldNullable: true);
        }
    }
}
