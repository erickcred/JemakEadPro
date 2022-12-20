using JemakEadPro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JemakEadPro.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired(false)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(200)");

            builder.Property(x => x.Email)
                .IsRequired(false)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(200)");

            builder.Property(x => x.CPF)
                .IsRequired(false)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR(11)");

            builder.Property(x => x.RG)
                .IsRequired(false)
                .HasColumnName("RG")
                .HasColumnType("VARCHAR(10)");

            builder.Property(x => x.Telefone)
                .IsRequired(false)
                .HasColumnName("Telefone")
                .HasColumnType("VARCHAR(13)");

            builder.Property(x => x.Celular)
                .IsRequired(false)
                .HasColumnName("Celular")
                .HasColumnType("VARCHAR(13)");

            builder.Property(x => x.TelefoneTrabalho)
                .IsRequired(false)
                .HasColumnName("TelefoneTrabalho")
                .HasColumnType("VARCHAR(13)");

            builder.Property(x => x.Sexo)
                .IsRequired(false)
                .HasColumnName("Sexo")
                .HasColumnType("VARCHAR(15)");

            builder.Property(x => x.DataNascimento)
                .IsRequired()
                .HasColumnName("DataNascimento")
                .HasColumnType("DateTime");

            builder.Property(x => x.CarteiraProfissional)
                .IsRequired(false)
                .HasColumnName("CarteiraProficional")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Senha)
                .IsRequired(false)
                .HasColumnName("Senha")
                .HasColumnType("VARCHAR(255)");

            builder.Property(x => x.Perfil)
                .IsRequired(false)
                .HasColumnName("Perfil")
                .HasColumnType("VARCHAR(100)")
                .HasDefaultValue("usuario");

            builder.Property(x => x.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("DateTime");

            builder.Property(x => x.Imagem)
                .IsRequired(false)
                .HasColumnName("Imagem")
                .HasColumnType("VARCHAR(255)");

            builder.Property(x => x.TipoUsuario)
                .IsRequired()
                .HasColumnName("TipoUsuario")
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("BOOL")
                .HasDefaultValue(true);


            builder.Property(x => x.CEP)
                .IsRequired(false)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR(10)");

            builder.Property(x => x.Endereco)
                .IsRequired(false)
                .HasColumnName("Endereco")
                .HasColumnType("VARCHAR(200)");

            builder.Property(x => x.Numero)
                .IsRequired(false)
                .HasColumnName("Numero")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Complemento)
                .IsRequired(false)
                .HasColumnName("Complemento")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Estado)
                .IsRequired(false)
                .HasColumnName("Estado")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Cidade)
                .IsRequired(false)
                .HasColumnName("Cidade")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Bairro)
                .IsRequired(false)
                .HasColumnName("Bairro")
                .HasColumnType("VARCHAR(100)");


            builder.Property(x => x.NomeResponsavel)
                .IsRequired(false)
                .HasColumnName("NomeResponsavel")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.CpfCnpj)
                .IsRequired(false)
                .HasColumnName("CpfCnpj")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.ResponsavelTelefone)
                .IsRequired(false)
                .HasColumnName("ResponsavelTelefone")
                .HasColumnType("VARCHAR(13)");



            builder.HasIndex(x => x.Nome).HasName("Ix_Usuario_Nome");
            builder.HasIndex(x => x.CPF).HasName("IX_Usuario_CPF").IsUnique();
            builder.HasIndex(x => x.Email).HasName("IX_Usuario_Email").IsUnique();
        }
    }
}