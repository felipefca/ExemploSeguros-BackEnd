using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class QuantidadeVeiculosMapping : EntityTypeConfiguration<QuantidadeVeiculos>
    {
        public override void Map(EntityTypeBuilder<QuantidadeVeiculos> builder)
        {
            builder.HasKey(q => q.QuantidadeVeiculoId);

            builder.Property(q => q.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("QuantidadeVeiculos");
        }
    }
}