using JemakEadPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JemakEadPro.Data.Mappings
{
    public class ContratoMap : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contrato");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Aluno)
                .WithMany(x => x.Contratos)
                .IsRequired(false)
                .HasConstraintName("FK_Contrato_Aluno")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(x => x.DataMatricula)
                .HasColumnName("DataMatricula")
                .HasColumnType("DATETIME");

            builder.Property(x => x.DataEncerramento)
                .HasColumnName("DataEncerramento")
                .HasColumnType("DATETIME");
        }
    }
}