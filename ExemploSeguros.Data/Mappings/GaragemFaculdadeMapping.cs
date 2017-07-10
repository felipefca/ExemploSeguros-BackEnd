using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class GaragemFaculdadeMapping : EntityTypeConfiguration<GararemFaculdade>
    {
        public override void Map(EntityTypeBuilder<GararemFaculdade> builder)
        {
            builder.HasKey(g => g.GaragemFaculdadeId);

            builder.Property(g => g.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("GaragemFaculdade");
        }
    }
}