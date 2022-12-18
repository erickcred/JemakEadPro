﻿// <auto-generated />
using System;
using JemakEadPro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JemakEadPro.Migrations
{
    [DbContext(typeof(JemakEadProContext))]
    [Migration("20221206181857_CursoAndamento")]
    partial class CursoAndamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
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

            modelBuilder.Entity("JemakEadPro.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnName("CargaHoraria")
                        .HasColumnType("INT(10)");

                    b.Property<string>("Categoria")
                        .HasColumnName("Categoria")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CategoriasPontuacao")
                        .HasColumnName("CategoriasPontuacao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CodigoCRC")
                        .HasColumnName("CodigoCRC")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnName("DataAtualizacao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnName("DataCriacao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataValidarCRC")
                        .HasColumnName("DataValidarCRC")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DataVencimentoCRC")
                        .HasColumnName("DataVencimentoCRC")
                        .HasColumnType("DateTime");

                    b.Property<string>("Imagem")
                        .HasColumnName("Imagem")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("Pontos")
                        .HasColumnName("Pontos")
                        .HasColumnType("INT(10)");

                    b.Property<string>("Professor")
                        .HasColumnName("Professor")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Situacao")
                        .HasColumnName("Situacao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("TurmaCRC")
                        .HasColumnName("TurmaCRC")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .HasName("Ix_Curso_Nome");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("JemakEadPro.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.ToTable("Material");
                });

            modelBuilder.Entity("JemakEadPro.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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
                        .HasColumnType("VARCHAR(12)");

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

                    b.Property<string>("Duracao")
                        .HasColumnName("Duracao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("ProjetoId")
                        .HasColumnName("ProjetoId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("VideoId")
                        .IsRequired()
                        .HasColumnName("VideoId")
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

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
#pragma warning restore 612, 618
        }
    }
}
