using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class DistanciaTrabalhoMapping : EntityTypeConfiguration<DistanciaTrabalho>
    {
        public override void Map(EntityTypeBuilder<DistanciaTrabalho> builder)
        {
            builder.HasKey(d => d.DistanciaTrabalhoId);

            builder.Property(d => d.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("DistanciaTrabalho");
        }
    }
}