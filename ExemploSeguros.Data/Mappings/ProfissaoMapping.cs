using System;
using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.ClienteRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class ProfissaoMapping : EntityTypeConfiguration<Profissao>
    {
        public override void Map(EntityTypeBuilder<Profissao> builder)
        {
            builder.HasKey(p => p.ProfissaoId);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.ToTable("Profissoes");
        }
    }
}