using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public override void Map(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Produtos");
        }
    }
}