using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class ImpostoMapping : EntityTypeConfiguration<Imposto>
    {
        public override void Map(EntityTypeBuilder<Imposto> builder)
        {
            builder.HasKey(i => i.ImpostoId);

            builder.Property(i => i.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Impostos");
        }
    }
}