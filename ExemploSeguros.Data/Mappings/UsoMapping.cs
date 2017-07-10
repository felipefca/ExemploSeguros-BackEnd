using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class UsoMapping : EntityTypeConfiguration<Uso>
    {
        public override void Map(EntityTypeBuilder<Uso> builder)
        {
            builder.HasKey(u => u.UsoId);

            builder.Property(u => u.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Usos");
        }
    }
}