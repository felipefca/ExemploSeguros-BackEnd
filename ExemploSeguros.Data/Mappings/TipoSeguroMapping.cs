using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class TipoSeguroMapping : EntityTypeConfiguration<TipoSeguro>
    {
        public override void Map(EntityTypeBuilder<TipoSeguro> builder)
        {
            builder.HasKey(t => t.TipoSeguroId);

            builder.Property(t => t.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("TipoSeguro");
        }
    }
}