using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class CoberturasItemMapping : EntityTypeConfiguration<CoberturasItem>
    {
        public override void Map(EntityTypeBuilder<CoberturasItem> builder)
        {
            builder.Property(c => c.Valor)
                .IsRequired();

            builder.HasOne(c => c.Item)
                .WithMany(i => i.Coberturas)
                .HasForeignKey(c => c.ItemId);

            builder.HasOne(c => c.Coberturas)
                .WithMany(i => i.CoberturasItems)
                .HasForeignKey(c => c.CoberturaId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("ItemCoberturas");
        }
    }
}