using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class MarcaMapping : EntityTypeConfiguration<Marca>
    {
        public override void Map(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(m => m.MarcaId);

            builder.Property(m => m.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(m => m.Imagem)
                .HasColumnType("varchar(150)")
                .IsRequired(false);

            builder.ToTable("Marcas");
        }
    }
}