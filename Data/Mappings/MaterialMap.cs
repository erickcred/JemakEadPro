using System;
using JemakEadPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JemakEadPro.Data.Mappings
{
    public class MaterialMap : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.ToTable("Material");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(200)");
            
            builder.Property(x => x.Url)
                .HasColumnName("Url")
                .HasColumnType("VARCHAR(200)");


            builder.HasOne(x => x.Curso)
                .WithMany(x => x.Materiais)
                .IsRequired(false)
                .HasConstraintName("FK_Material_Curso")
                .OnDelete(DeleteBehavior.NoAction);
                

            builder.Property(x => x.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("DateTime");

            builder.Property(x => x.DataAtualizacao)
                .HasColumnName("DataAtualizacao")
                .HasColumnType("DateTime");
        }
    }
}