using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class TempoHabilitacaoMapping : EntityTypeConfiguration<TempoHabilitacao>
    {
        public override void Map(EntityTypeBuilder<TempoHabilitacao> builder)
        {
            builder.HasKey(t => t.TempoHabilitacaoId);

            builder.Property(t => t.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("TempoHabilitacao");
        }
    }
}