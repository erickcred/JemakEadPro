using JemakEadPro.Models;
using JemakEadPro.Models.Enums.Curso;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JemakEadPro.Data.Mappings
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.Property(x => x.ProjetoToken)
                .IsRequired(false)
                .HasColumnName("ProjetoToken")
                .HasColumnType("VARCHAR(200)");

            builder.Property(x => x.ProjetoId)
                .HasColumnName("ProjetoId")
                .HasColumnType("INT(10)");

            builder.Property(x => x.ProjetoPlayerKey)
                .IsRequired(false)
                .HasColumnName("ProjetoPlayerKey")
                .HasColumnType("VARCHAR(200)");



            builder.Property(x => x.Nome)
                .IsRequired(false)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(200)");

            builder.Property(x => x.Imagem)
                .IsRequired(false)
                .HasColumnName("Imagem")
                .HasColumnType("VARCHAR(255)");

            builder.Property(x => x.Situacao)
                .IsRequired(false)
                .HasColumnName("Situacao")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Categoria)
                .IsRequired(false)
                .HasColumnName("Categoria")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.TipoCurso)
                .IsRequired()
                .HasColumnName("TipoCurso")
                .HasColumnType("VARCHAR(50)");


            builder.Property(x => x.CargaHoraria)
                .HasColumnName("CargaHoraria")
                .HasColumnType("INT(10)");

            builder.Property(x => x.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("BOOL")
                .HasDefaultValue(true);

            builder.HasOne(x => x.Contrato)
                .WithMany(x => x.Cursos)
                .IsRequired(false)
                .HasConstraintName("FK_Curso_Contrato")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.Descricao)
                .IsRequired(false)
                .HasColumnName("Descricao")
                .HasColumnType("TEXT");
            
            builder.Property(x => x.Objetivo)
                .IsRequired(false)
                .HasColumnName("Objetivo")
                .HasColumnType("TEXT");
            
            builder.Property(x => x.ParaQuem)
                .IsRequired(false)
                .HasColumnName("ParaQuem")
                .HasColumnType("TEXT");

            builder.Property(x => x.EstruturaDoCurso)
                .IsRequired(false)
                .HasColumnName("EstruturaDoCurso")
                .HasColumnType("TEXT");

            builder.Property(x => x.AcessoIlimitado)
                .IsRequired(false)
                .HasColumnName("AcessoIlimitado")
                .HasColumnType("TEXT");

            builder.Property(x => x.Metodologia)
                .IsRequired(false)
                .HasColumnName("Metodologia")
                .HasColumnType("TEXT");

            builder.Property(x => x.Excelencia)
                .IsRequired(false)
                .HasColumnName("Excelencia")
                .HasColumnType("TEXT");

            builder.Property(x => x.Atencao)
                .IsRequired(false)
                .HasColumnName("Atencao")
                .HasColumnType("TEXT");




            builder.Property(x => x.Professor)
                .IsRequired(false)
                .HasColumnName("Professor")
                .HasColumnType("VARCHAR(100)");


            builder.Property(x => x.DataSubmicaoCRC)
                .HasColumnName("DataSubmicaoCRC")
                .HasColumnType("DateTime");

            builder.Property(x => x.DataVencimentoCRC)
                .HasColumnName("DataVencimentoCRC")
                .HasColumnType("DateTime");

            builder.Property(x => x.TurmaCRC)
                .IsRequired(false)
                .HasColumnName("TurmaCRC")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.CodigoCursoCRC)
                .IsRequired(false)
                .HasColumnName("CodigoCursoCRC")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.CategoriasPontuacao)
                .IsRequired(false)
                .HasColumnName("CategoriasPontuacao")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Pontos)
                .HasColumnName("Pontos")
                .HasColumnType("INT(10)");


            builder.Property(x => x.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("DateTime");

            builder.Property(x => x.DataAtualizacao)
                .HasColumnName("DataAtualizacao")
                .HasColumnType("DateTime");


            builder.HasIndex(x => x.Nome).HasName("Ix_Curso_Nome");
        }
    }
}