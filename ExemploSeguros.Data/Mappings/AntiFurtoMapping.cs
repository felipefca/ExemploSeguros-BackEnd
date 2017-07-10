using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class AntiFurtoMapping : EntityTypeConfiguration<AntiFurto>
    {
        public override void Map(EntityTypeBuilder<AntiFurto> builder)
        {
            builder.HasKey(a => a.AntiFurtoId);

            builder.Property(a => a.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("AntiFurto");
        }
    }
}