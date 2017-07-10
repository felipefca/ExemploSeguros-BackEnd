using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class TipoResidenciaMapping : EntityTypeConfiguration<TipoResidencia>
    {
        public override void Map(EntityTypeBuilder<TipoResidencia> builder)
        {
            builder.HasKey(t => t.TipoResidenciaId);

            builder.Property(t => t.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("TipoResidencia");
        }
    }
}