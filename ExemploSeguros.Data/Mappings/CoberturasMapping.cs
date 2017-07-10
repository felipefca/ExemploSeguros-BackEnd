using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class CoberturasMapping : EntityTypeConfiguration<Coberturas>
    {
        public override void Map(EntityTypeBuilder<Coberturas> builder)
        {
            builder.HasKey(c => c.CoberturaId);

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(c => c.Imagem)
                .IsRequired(false);

            builder.Property(c => c.Info)
                .HasColumnType("varchar(1500)")
                .IsRequired();

            builder.ToTable("Coberturas");
        }
    }
}