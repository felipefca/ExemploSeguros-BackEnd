using System;
using System.IO;
using System.Linq;
using System.Reflection;
using ExemploSeguros.Data.Extensions;
using ExemploSeguros.Data.Mappings;
using ExemploSeguros.Domain.Models.ClienteRoot;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Models.PerfilRoot;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ExemploSeguros.Data.Context
{
    public class ExemploSegurosContext : DbContext
    {
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<TipoCalculo> TiposCalculo { get; set; }
        public DbSet<TipoSeguro> TiposSeguro { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PaisResidencia> Paises { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Imposto> Impostos { get; set; }
        public DbSet<Uso> Usos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<AntiFurto> AntiFurtos { get; set; }
        public DbSet<GararemFaculdade> GararemFaculdades { get; set; }
        public DbSet<GararemResidencia> GararemResidencias { get; set; }
        public DbSet<GararemTrabalho> GararemTrabalhos { get; set; }
        public DbSet<PropriedadeRastreador> PropriedadeRastreadores { get; set; }
        public DbSet<Rastreador> Rastreadores  { get; set; }
        public DbSet<RelacaoSegurado> RelacaoSegurados { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<DistanciaTrabalho> DistanciaTrabalho { get; set; }
        public DbSet<EstadoCivil> EstadoCivi { get; set; }
        public DbSet<QuantidadeVeiculos> QuantidadeVeiculos { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<TempoHabilitacao> TempoHabilitacao { get; set; }
        public DbSet<TipoResidencia> TipoResidencias { get; set; }
        public DbSet<Coberturas> Coberturas { get; set; }
        public DbSet<CoberturasProduto> CoberturasProduto { get; set; }
        public DbSet<CoberturasItem> ItemCoberturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CotacaoMapping());
            modelBuilder.AddConfiguration(new TipoSeguroMapping());
            modelBuilder.AddConfiguration(new TipoCalculoMapping());
            modelBuilder.AddConfiguration(new ClienteMapping());
            modelBuilder.AddConfiguration(new EnderecoMapping());
            modelBuilder.AddConfiguration(new PaisResidenciaMapping());
            modelBuilder.AddConfiguration(new ProfissaoMapping());
            modelBuilder.AddConfiguration(new ItemMapping());
            modelBuilder.AddConfiguration(new ImpostoMapping());
            modelBuilder.AddConfiguration(new UsoMapping());
            modelBuilder.AddConfiguration(new MarcaMapping());
            modelBuilder.AddConfiguration(new ModeloMapping());
            modelBuilder.AddConfiguration(new ProdutoMapping());
            modelBuilder.AddConfiguration(new QuestionarioMapping());
            modelBuilder.AddConfiguration(new AntiFurtoMapping());
            modelBuilder.AddConfiguration(new GaragemFaculdadeMapping());
            modelBuilder.AddConfiguration(new GaragemResidenciaMapping());
            modelBuilder.AddConfiguration(new GaragemTrabalhoMapping());
            modelBuilder.AddConfiguration(new PropriedadeRastreadorMapping());
            modelBuilder.AddConfiguration(new RastreadorMapping());
            modelBuilder.AddConfiguration(new RelacaoSeguradoMapping());
            modelBuilder.AddConfiguration(new PerfilMapping());
            modelBuilder.AddConfiguration(new EstadoCivilMapping());
            modelBuilder.AddConfiguration(new DistanciaTrabalhoMapping());
            modelBuilder.AddConfiguration(new QuantidadeVeiculosMapping());
            modelBuilder.AddConfiguration(new SexoMapping());
            modelBuilder.AddConfiguration(new TempoHabilitacaoMapping());
            modelBuilder.AddConfiguration(new TipoResidenciaMapping());
            modelBuilder.AddConfiguration(new CoberturasMapping());
            modelBuilder.AddConfiguration(new CoberturasProdutoMapping());
            modelBuilder.AddConfiguration(new CoberturasItemMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("ExemploSegurosConnection"));
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = true;
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCalculo") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCalculo").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataCalculo").IsModified = true;
            }

            return base.SaveChanges();
        }
    }
}