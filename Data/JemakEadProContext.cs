using Microsoft.EntityFrameworkCore;
using JemakEadPro.Data.Mappings;
using JemakEadPro.Models;

namespace JemakEadPro.Data
{
    public class JemakEadProContext : DbContext
    {
        public JemakEadProContext(DbContextOptions<JemakEadProContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Andamento> Andamentos { get; set; }
        public DbSet<Material> Materiais { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.EnableSensitiveDataLogging();
        // }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new CursoMap());
            builder.ApplyConfiguration(new VideoMap());
            builder.ApplyConfiguration(new AndamentoMap());
            builder.ApplyConfiguration(new MaterialMap());
        }
    }
}