using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploSeguros.Data.Mappings
{
    public class PerfilMapping : EntityTypeConfiguration<Perfil>
    {
        public override void Map(EntityTypeBuilder<Perfil> builder)
        {
            builder.Property(p => p.CpfPrincipalCondutor)
               .HasColumnType("varchar(11)")
               .HasMaxLength(11)
               .IsRequired();

            builder.Property(p => p.NomePrincipalCondutor)
               .HasColumnType("varchar(50)")
               .IsRequired();

            builder.Property(p => p.DataNascPrincipalCondutor)
               .IsRequired();

            builder.Property(p => p.FlagResideMenorIdade)
                .IsRequired();

            builder.Property(p => p.FlagSegPrincipalCondutor)
                .IsRequired();

            builder.Property(p => p.FlagPontosCarteira)
                .IsRequired();

            builder.HasOne(p => p.EstadoCivil)
                .WithMany(e => e.Perfis)
                .HasForeignKey(p => p.EstadoCivilId)
                .IsRequired();

            builder.HasOne(p => p.TipoResidencia)
                .WithMany(t => t.Perfis)
                .HasForeignKey(p => p.TipoResidenciaId)
                .IsRequired();

            builder.HasOne(p => p.Sexo)
                .WithMany(s => s.Perfis)
                .HasForeignKey(p => p.SexoId)
                .IsRequired();

            builder.HasOne(p => p.TempoHabilitacao)
                .WithMany(t => t.Perfis)
                .HasForeignKey(p => p.TempoHabilitacaoId)
                .IsRequired();

            builder.HasOne(p => p.DistanciaTrabalho)
                .WithMany(d => d.Perfis)
                .HasForeignKey(p => p.DistanciaTrabalhoId)
                .IsRequired();

            builder.HasOne(p => p.QuantidadeVeiculos)
                .WithMany(q => q.Perfis)
                .HasForeignKey(p => p.QuantidadeVeiculoId)
                .IsRequired();

            builder.HasOne(p => p.Cotacao)
                .WithOne(c => c.Perfil)
                .HasForeignKey<Perfil>(p => p.CotacaoId);

            builder.Ignore(p => p.ValidationResult);

            builder.Ignore(p => p.CascadeMode);

            builder.ToTable("Perfis");
        }
    }
}