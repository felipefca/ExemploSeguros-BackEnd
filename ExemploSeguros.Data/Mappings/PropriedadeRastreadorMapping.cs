using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class PropriedadeRastreadorMapping : EntityTypeConfiguration<PropriedadeRastreador>
    {
        public override void Map(EntityTypeBuilder<PropriedadeRastreador> builder)
        {
            builder.HasKey(p => p.PropriedadeRastreadorId);

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("PropriedadeRastreador");
        }
    }
}