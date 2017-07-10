using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class RelacaoSeguradoMapping : EntityTypeConfiguration<RelacaoSegurado>
    {
        public override void Map(EntityTypeBuilder<RelacaoSegurado> builder)
        {
            builder.HasKey(r => r.RelacaoSeguradoId);

            builder.Property(r => r.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("RelacaoSegurado");
        }
    }
}