using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ClienteRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(c => c.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(c => c.SobreNome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(c => c.Cpf)
               .HasColumnType("varchar(11)")
               .HasMaxLength(11)
               .IsRequired();

            builder.Property(c => c.Telefone)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(c => c.Rg)
                .HasColumnType("varchar(7)")
                .HasMaxLength(7)
                .IsRequired();
            
            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.Property(c => c.DataNascimento)
                .IsRequired();

            builder.HasOne(c => c.PaisResidencia)
                .WithMany(p => p.Clientes)
                .HasForeignKey(c => c.PaisResidenciaId);

            builder.HasOne(c => c.Profissao)
                .WithMany(p => p.Clientes)
                .HasForeignKey(c => c.ProfissaoId);

            builder.HasOne(cl => cl.Cotacao)
                .WithOne(co => co.Cliente)
                .HasForeignKey<Cliente>(cl => cl.CotacaoId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Clientes");
        }
    }
}