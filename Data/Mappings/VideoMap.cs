using JemakEadPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JemakEadPro.Data.Mappings
{
    public class VideoMap : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable("Video");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired(false)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(255)");

            builder.Property(x => x.ProjetoId)
                .IsRequired(false)
                .HasColumnName("ProjetoId")
                .HasColumnType("varchar(255)");

            builder.Property(x => x.VideoId)
                .IsRequired()
                .HasColumnName("VideoId")
                .HasColumnType<string>("VARCHAR(255)");

            builder.Property(x => x.Url)
                .IsRequired(false)
                .HasColumnName("Url")
                .HasColumnType("VARCHAR(200)");

            builder.Property(x => x.Ordem)
                .HasColumnName("Ordem")
                .HasColumnType("INT");

            builder.Property(x => x.Duracao)
                .IsRequired(false)
                .HasColumnName("Duracao")
                .HasColumnType("VARCHAR(100)");

            
            builder.HasOne(x => x.Curso)
                .WithMany(x => x.Videos)
                .IsRequired(false)
                .HasConstraintName("FK_Video_Curso")
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}