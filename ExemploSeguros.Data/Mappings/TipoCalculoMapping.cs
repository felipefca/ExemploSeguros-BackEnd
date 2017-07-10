using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class TipoCalculoMapping : EntityTypeConfiguration<TipoCalculo>
    {
        public override void Map(EntityTypeBuilder<TipoCalculo> builder)
        {
            builder.HasKey(t => t.TipoCalculoId);

            builder.Property(t => t.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("TipoCalculo");
        }
    }
}