using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class ItemMapping : EntityTypeConfiguration<Item>
    {
        public override void Map(EntityTypeBuilder<Item> builder)
        {
            builder.HasOne(i => i.Produto)
                .WithMany()
                .HasForeignKey(i => i.ProdutoId);

            builder.HasOne(i => i.Modelo)
                .WithMany()
                .HasForeignKey(i => i.ModeloId);

            builder.Property(i => i.NumChassi)
                 .IsRequired(false);

            builder.Property(i => i.FlagRemarcado)
                 .IsRequired();

            builder.Property(i => i.DataSaida)
                 .IsRequired(false)
                 .HasMaxLength(50)
                 .HasColumnType("varchar(50)");

            builder.Property(i => i.Odometro)
                 .IsRequired(false);

            builder.HasOne(i => i.Imposto)
                .WithMany(x => x.Itens)
                .HasForeignKey(i => i.ImpostoId);

            builder.HasOne(i => i.Uso)
                .WithMany(u => u.Itens)
                .HasForeignKey(i => i.UsoId);

            builder.HasOne(i => i.Cotacao)
                .WithOne(c => c.Item)
                .HasForeignKey<Item>(i => i.CotacaoId);

            builder.Ignore(i => i.ValidationResult);

            builder.Ignore(i => i.CascadeMode);

            builder.ToTable("Itens");
        }
    }
}