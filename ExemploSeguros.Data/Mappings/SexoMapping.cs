using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class SexoMapping : EntityTypeConfiguration<Sexo>
    {
        public override void Map(EntityTypeBuilder<Sexo> builder)
        {
            builder.HasKey(s => s.SexoId);

            builder.Property(s => s.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Sexo");
        }
    }
}