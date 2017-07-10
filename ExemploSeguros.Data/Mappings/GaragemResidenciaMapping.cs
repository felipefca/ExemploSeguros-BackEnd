using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class GaragemResidenciaMapping : EntityTypeConfiguration<GararemResidencia>
    {
        public override void Map(EntityTypeBuilder<GararemResidencia> builder)
        {
            builder.HasKey(g => g.GaragemResidenciaId);

            builder.Property(g => g.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("GaragemResidencia");
        }
    }
}