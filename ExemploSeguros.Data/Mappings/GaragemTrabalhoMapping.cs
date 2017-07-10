using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class GaragemTrabalhoMapping : EntityTypeConfiguration<GararemTrabalho>
    {
        public override void Map(EntityTypeBuilder<GararemTrabalho> builder)
        {
            builder.HasKey(g => g.GaragemTrabalhoId);

            builder.Property(g => g.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("GaragemTrabalho");
        }
    }
}