using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class CoberturasProdutoMapping : EntityTypeConfiguration<CoberturasProduto>
    {
        public override void Map(EntityTypeBuilder<CoberturasProduto> builder)
        {
            builder.HasKey(c => c.CoberturaProdutoId);

            builder.Property(c => c.FlagObrigatorio)
                .IsRequired();

            builder.Property(c => c.FlagBasica)
                .IsRequired();

            builder.Property(c => c.ValorMinimo)
                .IsRequired();

            builder.Property(c => c.ValorMaximo)
                .IsRequired(false);

            builder.Property(c => c.Taxa)
                .IsRequired();

            builder.HasOne(cob => cob.Coberturas)
                .WithMany(c => c.CoberturasProduto)
                .HasForeignKey(cob => cob.CoberturaId);

            builder.HasOne(cob => cob.Produtos)
                .WithMany(p => p.CoberturasProduto)
                .HasForeignKey(cob => cob.ProdutoId);

            builder.ToTable("CoberturasProduto");
        }
    }
}