using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class RastreadorMapping : EntityTypeConfiguration<Rastreador>
    {
        public override void Map(EntityTypeBuilder<Rastreador> builder)
        {
            builder.HasKey(r => r.RastreadorId);

            builder.Property(r => r.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Rastreadores");
        }
    }
}