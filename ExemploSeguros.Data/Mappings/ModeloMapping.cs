using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class ModeloMapping : EntityTypeConfiguration<Modelo>
    {
        public override void Map(EntityTypeBuilder<Modelo> builder)
        {
            builder.HasKey(m => m.ModeloId);

            builder.Property(m => m.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(m => m.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(m => m.AnoFabricacao)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(m => m.AnoModelo)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(m => m.FlagZeroKm)
                .IsRequired();

            builder.Property(m => m.Valor)
                .IsRequired();

            builder.Property(m => m.Franquia)
                .IsRequired();

            builder.HasOne(m => m.Marca)
                .WithMany(x => x.Modelos)
                .HasForeignKey(m => m.MarcaId);

            builder.ToTable("Modelos");
        }
    }
}