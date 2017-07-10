using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class EstadoCivilMapping : EntityTypeConfiguration<EstadoCivil>
    {
        public override void Map(EntityTypeBuilder<EstadoCivil> builder)
        {
            builder.HasKey(e => e.EstadoCivilId);

            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("EstadoCivil");
        }
    }
}