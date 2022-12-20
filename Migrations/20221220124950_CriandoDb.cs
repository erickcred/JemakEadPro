using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CriandoDb : Migration
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
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Imagem = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    TipoUsuario = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ativo = table.Column<bool>(type: "BOOL", nullable: true, defaultValue: true),
                    CEP = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Endereco = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Numero = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Complemento = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Cidade = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Bairro = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    NomeResponsavel = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CpfCnpj = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    ResponsavelTelefone = table.Column<string>(type: "VARCHAR(13)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjetoToken = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    ProjetoId = table.Column<int>(type: "INT(10)", nullable: false),
                    ProjetoPlayerKey = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Imagem = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Situacao = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Categoria = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CargaHoraria = table.Column<int>(type: "INT(10)", nullable: false),
                    TipoCurso = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ativo = table.Column<bool>(type: "BOOL", nullable: true, defaultValue: true),
                    ContratoId = table.Column<int>(nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Objetivo = table.Column<string>(type: "TEXT", nullable: true),
                    ParaQuem = table.Column<string>(type: "TEXT", nullable: true),
                    EstruturaDoCurso = table.Column<string>(type: "TEXT", nullable: true),
                    AcessoIlimitado = table.Column<string>(type: "TEXT", nullable: true),
                    Metodologia = table.Column<string>(type: "TEXT", nullable: true),
                    Excelencia = table.Column<string>(type: "TEXT", nullable: true),
                    Atencao = table.Column<string>(type: "TEXT", nullable: true),
                    Professor = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    DataSubmicaoCRC = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataVencimentoCRC = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TurmaCRC = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CodigoCursoCRC = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CategoriasPontuacao = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Pontos = table.Column<int>(type: "INT(10)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Curso_Contrato",
                        column: x => x.ContratoId,
                        principalTable: "Contrato",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Andamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: true),
                    DataInicio = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataFim = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Andamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Andamento_Curso",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Andamento_Usuario",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Url = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    CursoId = table.Column<int>(nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Curso",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    ProjetoId = table.Column<string>(type: "varchar(255)", nullable: true),
                    VideoId = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Url = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Ordem = table.Column<int>(type: "INT", nullable: false),
                    Duracao = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CursoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Curso",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Andamento_CursoId",
                table: "Andamento",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Andamento_UsuarioId",
                table: "Andamento",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_AlunoId",
                table: "Contrato",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_ContratoId",
                table: "Curso",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "Ix_Curso_Nome",
                table: "Curso",
                column: "Nome");

            migrationBuilder.CreateIndex(
                name: "IX_Material_CursoId",
                table: "Material",
                column: "CursoId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Video_CursoId",
                table: "Video",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Andamento");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
