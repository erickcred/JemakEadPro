using JemakEadPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JemakEadPro.Data.Mappings
{
    public class AndamentoMap : IEntityTypeConfiguration<Andamento>
    {
        public void Configure(EntityTypeBuilder<Andamento> builder)
        {
            builder.ToTable("Andamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Andamentos)
                .IsRequired(false)
                .HasConstraintName("FK_Andamento_Usuario")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Curso)
               .WithMany(x => x.Andamentos)
               .IsRequired(false)
               .HasConstraintName("FK_Andamento_Curso")
               .OnDelete(DeleteBehavior.NoAction);


            builder.Property(x => x.DataInicio)
                .HasColumnName("DataInicio")
                .HasColumnType("DateTime")
                .HasDefaultValue(null);

            builder.Property(x => x.DataFim)
                .HasColumnName("DataFim")
                .HasColumnType("DateTime")
                .HasDefaultValue(null);
        }
    }
}