// <auto-generated />
using System;
using JemakEadPro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JemakEadPro.Migrations
{
    [DbContext(typeof(JemakEadProContext))]
    [Migration("20221229160808_VideoProgresso")]
    partial class VideoProgresso
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JemakEadPro.Models.Andamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DataFim")
                        .HasColumnType("DateTime")
                        .HasDefaultValue(null);

                    b.Property<DateTime>("DataInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DataInicio")
                        .HasColumnType("DateTime")
                        .HasDefaultValue(null);

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Andamento");
                });

            modelBuilder.Entity("JemakEadPro.Models.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEncerramento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("JemakEadPro.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AcessoIlimitado")
                        .HasColumnName("AcessoIlimitado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Atencao")
                        .HasColumnName("Atencao")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Ativo")
                        .HasColumnType("BOOL")
                        .HasDefaultValue(true);

                    b.Property<int>("CargaHoraria")
                        .HasColumnName("CargaHoraria")
                        .HasColumnType("INT(10)");

                    b.Property<string>("Categoria")
                        .HasColumnName("Categoria")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CategoriasPontuacao")
                        .HasColumnName("CategoriasPontuacao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CodigoCursoCRC")
                        .HasColumnName("CodigoCursoCRC")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int?>("ContratoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnName("DataAtualizacao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnName("DataCriacao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataSubmicaoCRC")
                        .HasColumnName("DataSubmicaoCRC")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataVencimentoCRC")
                        .HasColumnName("DataVencimentoCRC")
                        .HasColumnType("DateTime");

                    b.Property<string>("Descricao")
                        .HasColumnName("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstruturaDoCurso")
                        .HasColumnName("EstruturaDoCurso")
                        .HasColumnType("TEXT");

                    b.Property<string>("Excelencia")
                        .HasColumnName("Excelencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Imagem")
                        .HasColumnName("Imagem")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Metodologia")
                        .HasColumnName("Metodologia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Objetivo")
                        .HasColumnName("Objetivo")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParaQuem")
                        .HasColumnName("ParaQuem")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pontos")
                        .HasColumnName("Pontos")
                        .HasColumnType("INT(10)");

                    b.Property<string>("Professor")
                        .HasColumnName("Professor")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("ProjetoId")
                        .HasColumnName("ProjetoId")
                        .HasColumnType("INT(10)");

                    b.Property<string>("ProjetoPlayerKey")
                        .HasColumnName("ProjetoPlayerKey")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("ProjetoToken")
                        .HasColumnName("ProjetoToken")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Situacao")
                        .HasColumnName("Situacao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("TipoCurso")
                        .IsRequired()
                        .HasColumnName("TipoCurso")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("TurmaCRC")
                        .HasColumnName("TurmaCRC")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("ContratoId");

                    b.HasIndex("Nome")
                        .HasName("Ix_Curso_Nome");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("JemakEadPro.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnName("DataAtualizacao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnName("DataCriacao")
                        .HasColumnType("DateTime");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Url")
                        .HasColumnName("Url")
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("JemakEadPro.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Ativo")
                        .HasColumnType("BOOL")
                        .HasDefaultValue(true);

                    b.Property<string>("Bairro")
                        .HasColumnName("Bairro")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CEP")
                        .HasColumnName("CEP")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("CPF")
                        .HasColumnName("CPF")
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("CarteiraProfissional")
                        .HasColumnName("CarteiraProficional")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Celular")
                        .HasColumnName("Celular")
                        .HasColumnType("VARCHAR(13)");

                    b.Property<string>("Cidade")
                        .HasColumnName("Cidade")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Complemento")
                        .HasColumnName("Complemento")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CpfCnpj")
                        .HasColumnName("CpfCnpj")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("DataCadastro")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("DataNascimento")
                        .HasColumnType("DateTime");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Endereco")
                        .HasColumnName("Endereco")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Estado")
                        .HasColumnName("Estado")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Imagem")
                        .HasColumnName("Imagem")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("NomeResponsavel")
                        .HasColumnName("NomeResponsavel")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Numero")
                        .HasColumnName("Numero")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Perfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Perfil")
                        .HasColumnType("VARCHAR(100)")
                        .HasDefaultValue("usuario");

                    b.Property<string>("RG")
                        .HasColumnName("RG")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("ResponsavelTelefone")
                        .HasColumnName("ResponsavelTelefone")
                        .HasColumnType("VARCHAR(13)");

                    b.Property<string>("Senha")
                        .HasColumnName("Senha")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Sexo")
                        .HasColumnName("Sexo")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Telefone")
                        .HasColumnName("Telefone")
                        .HasColumnType("VARCHAR(13)");

                    b.Property<string>("TelefoneTrabalho")
                        .HasColumnName("TelefoneTrabalho")
                        .HasColumnType("VARCHAR(13)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnName("TipoUsuario")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique()
                        .HasName("IX_Usuario_CPF");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("IX_Usuario_Email");

                    b.HasIndex("Nome")
                        .HasName("Ix_Usuario_Nome");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("JemakEadPro.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Duracao")
                        .HasColumnName("Duracao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<bool>("Finalizado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Finalizado")
                        .HasColumnType("BOOL")
                        .HasDefaultValue(false);

                    b.Property<bool>("Iniciado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Iniciado")
                        .HasColumnType("BOOL")
                        .HasDefaultValue(false);

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<int>("Ordem")
                        .HasColumnName("Ordem")
                        .HasColumnType("INT");

                    b.Property<string>("Progresso")
                        .HasColumnName("Progresso")
                        .HasColumnType("VARCHAR(3)");

                    b.Property<string>("ProjetoId")
                        .HasColumnName("ProjetoId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Url")
                        .HasColumnName("Url")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("VideoId")
                        .IsRequired()
                        .HasColumnName("VideoId")
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("JemakEadPro.Models.Andamento", b =>
                {
                    b.HasOne("JemakEadPro.Models.Curso", "Curso")
                        .WithMany("Andamentos")
                        .HasForeignKey("CursoId")
                        .HasConstraintName("FK_Andamento_Curso")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("JemakEadPro.Models.Usuario", "Usuario")
                        .WithMany("Andamentos")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK_Andamento_Usuario")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("JemakEadPro.Models.Contrato", b =>
                {
                    b.HasOne("JemakEadPro.Models.Usuario", "Aluno")
                        .WithMany("Contratos")
                        .HasForeignKey("AlunoId");
                });

            modelBuilder.Entity("JemakEadPro.Models.Curso", b =>
                {
                    b.HasOne("JemakEadPro.Models.Contrato", "Contrato")
                        .WithMany("Cursos")
                        .HasForeignKey("ContratoId")
                        .HasConstraintName("FK_Curso_Contrato")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("JemakEadPro.Models.Material", b =>
                {
                    b.HasOne("JemakEadPro.Models.Curso", "Curso")
                        .WithMany("Materiais")
                        .HasForeignKey("CursoId")
                        .HasConstraintName("FK_Material_Curso")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("JemakEadPro.Models.Video", b =>
                {
                    b.HasOne("JemakEadPro.Models.Curso", "Curso")
                        .WithMany("Videos")
                        .HasForeignKey("CursoId")
                        .HasConstraintName("FK_Video_Curso")
                        .OnDelete(DeleteBehavior.NoAction);
                });
#pragma warning restore 612, 618
        }
    }
}
