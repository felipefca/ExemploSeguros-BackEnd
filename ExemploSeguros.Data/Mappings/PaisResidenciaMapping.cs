using System;
using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ClienteRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class PaisResidenciaMapping : EntityTypeConfiguration<PaisResidencia>
    {
        public override void Map(EntityTypeBuilder<PaisResidencia> builder)
        {
            builder.HasKey(p => p.PaisResidenciaId);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Paises");
        }
    }
}