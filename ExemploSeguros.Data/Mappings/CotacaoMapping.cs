using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class CotacaoMapping : EntityTypeConfiguration<Cotacao>
    {
        public override void Map(EntityTypeBuilder<Cotacao> builder)
        {
            builder.Property(c => c.NumCotacao)
                .IsRequired();

            builder.Property(c => c.UserId)
                .IsRequired();

            builder.Property(c => c.DataCadastro)
                .IsRequired();

            builder.Property(c => c.DataCalculo)
                .IsRequired();

            builder.Property(c => c.DataVigenciaInicial)
                .IsRequired();

            builder.Property(c => c.DataVigenciaFinal)
                .IsRequired();

            builder.Property(c => c.PremioTotal)
                .IsRequired();

            builder.HasOne(c => c.TipoCalculo)
                .WithMany(t => t.Cotacoes)
                .HasForeignKey(c => c.TipoCalculoId);

            builder.HasOne(c => c.TipoSeguro)
                .WithMany(t => t.Cotacoes)
                .HasForeignKey(c => c.TipoSeguroId);

            builder.Ignore(c => c.ValidationResult);

            builder.Ignore(c => c.CascadeMode);

            builder.ToTable("Cotacoes");
        }
    }
}