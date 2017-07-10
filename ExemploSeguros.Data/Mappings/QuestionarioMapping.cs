using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class QuestionarioMapping : EntityTypeConfiguration<Questionario>
    {
        public override void Map(EntityTypeBuilder<Questionario> builder)
        {
            builder.Property(q => q.CepPernoite)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnType("varchar(8)");

            builder.Property(q => q.FlagBlindado)
                .IsRequired();

            builder.Property(q => q.FlagAdaptadoDeficiente)
                .IsRequired();

            builder.Property(q => q.FlagKitGas)
                .IsRequired();

            builder.Property(q => q.FlagAlienado)
                .IsRequired();

            builder.Property(q => q.FlagAntiFurto)
                .IsRequired();

            builder.Property(q => q.FlagGararem)
                .IsRequired();

            builder.HasOne(q => q.Rastreador)
                .WithMany(r => r.Questionarios)
                .HasForeignKey(q => q.RastreadorId)
                .IsRequired(false);

            builder.HasOne(q => q.AntiFurto)
                .WithMany(a => a.Questionarios)
                .HasForeignKey(q => q.AntiFurtoId)
                .IsRequired(false);

            builder.HasOne(q => q.RelacaoSegurado)
                .WithMany(r => r.Questionarios)
                .HasForeignKey(q => q.RelacaoSeguradoId)
                .IsRequired();

            builder.HasOne(q => q.GararemResidencia)
                .WithMany(x => x.Questionarios)
                .HasForeignKey(q => q.GararemResidenciaId)
                .IsRequired(false);

            builder.HasOne(q => q.GararemTrabalho)
                .WithMany(x => x.Questionarios)
                .HasForeignKey(q => q.GararemTrabalhoId)
                .IsRequired(false);

            builder.HasOne(q => q.GararemFaculdade)
                .WithMany(x => x.Questionarios)
                .HasForeignKey(q => q.GaragemFaculdadeId)
                .IsRequired(false);

            builder.HasOne(q => q.PropriedadeRastreador)
                .WithMany(p => p.Questionarios)
                .HasForeignKey(q => q.PropriedadeRastreadorId)
                .IsRequired(false);

            builder.HasOne(q => q.Cotacao)
                .WithOne(c => c.Questionario)
                .HasForeignKey<Questionario>(i => i.CotacaoId);

            builder.Ignore(i => i.ValidationResult);

            builder.Ignore(i => i.CascadeMode);

            builder.ToTable("Questionarios");
        }
    }
}