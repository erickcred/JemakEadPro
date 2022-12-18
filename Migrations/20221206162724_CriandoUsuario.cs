using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CriandoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    CPF = table.Column<string>(type: "VARCHAR(11)", nullable: true),
                    RG = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(13)", nullable: true),
                    Celular = table.Column<string>(type: "VARCHAR(13)", nullable: true),
                    TelefoneTrabalho = table.Column<string>(type: "VARCHAR(13)", nullable: true),
                    Sexo = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CarteiraProficional = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Senha = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Perfil = table.Column<string>(type: "VARCHAR(100)", nullable: true, defaultValue: "usuario"),
                    CEP = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Endereco = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Numero = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Complemento = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Cidade = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Bairro = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    NomeResponsavel = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CpfCnpj = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    ResponsavelTelefone = table.Column<string>(type: "VARCHAR(12)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CPF",
                table: "Usuario",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Ix_Usuario_Nome",
                table: "Usuario",
                column: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
