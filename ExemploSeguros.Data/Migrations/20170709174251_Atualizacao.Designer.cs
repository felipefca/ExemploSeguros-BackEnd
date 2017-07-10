using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ExemploSeguros.Data.Context;

namespace ExemploSeguros.Data.Migrations
{
    [DbContext(typeof(ExemploSegurosContext))]
    [Migration("20170709174251_Atualizacao")]
    partial class Atualizacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ClienteRoot.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CotacaoId");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PaisResidenciaId");

                    b.Property<int>("ProfissaoId");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("varchar(7)")
                        .HasMaxLength(7);

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoId")
                        .IsUnique();

                    b.HasIndex("PaisResidenciaId");

                    b.HasIndex("ProfissaoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ClienteRoot.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("ClienteId");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ClienteRoot.PaisResidencia", b =>
                {
                    b.Property<int>("PaisResidenciaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("PaisResidenciaId");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ClienteRoot.Profissao", b =>
                {
                    b.Property<int>("ProfissaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("ProfissaoId");

                    b.ToTable("Profissoes");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CoberturasRoot.Coberturas", b =>
                {
                    b.Property<int>("CoberturaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Imagem");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("varchar(1500)");

                    b.HasKey("CoberturaId");

                    b.ToTable("Coberturas");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CoberturasRoot.CoberturasItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoberturaId");

                    b.Property<Guid>("ItemId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("CoberturaId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemCoberturas");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CoberturasRoot.CoberturasProduto", b =>
                {
                    b.Property<int>("CoberturaProdutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoberturaId");

                    b.Property<bool>("FlagBasica");

                    b.Property<bool>("FlagObrigatorio");

                    b.Property<int>("ProdutoId");

                    b.Property<double>("Taxa");

                    b.Property<float?>("ValorMaximo");

                    b.Property<float>("ValorMinimo");

                    b.HasKey("CoberturaProdutoId");

                    b.HasIndex("CoberturaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CoberturasProduto");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CotacaoRoot.Cotacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataCalculo");

                    b.Property<DateTime>("DataVigenciaFinal");

                    b.Property<DateTime>("DataVigenciaInicial");

                    b.Property<int>("NumCotacao");

                    b.Property<decimal>("PremioTotal");

                    b.Property<int>("TipoCalculoId");

                    b.Property<int>("TipoSeguroId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TipoCalculoId");

                    b.HasIndex("TipoSeguroId");

                    b.ToTable("Cotacoes");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CotacaoRoot.TipoCalculo", b =>
                {
                    b.Property<int>("TipoCalculoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("TipoCalculoId");

                    b.ToTable("TipoCalculo");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CotacaoRoot.TipoSeguro", b =>
                {
                    b.Property<int>("TipoSeguroId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("TipoSeguroId");

                    b.ToTable("TipoSeguro");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Imposto", b =>
                {
                    b.Property<int>("ImpostoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("ImpostoId");

                    b.ToTable("Impostos");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CotacaoId");

                    b.Property<string>("DataSaida")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("FlagRemarcado");

                    b.Property<int>("ImpostoId");

                    b.Property<int>("ModeloId");

                    b.Property<long?>("NumChassi");

                    b.Property<int?>("Odometro");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("UsoId");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoId")
                        .IsUnique();

                    b.HasIndex("ImpostoId");

                    b.HasIndex("ModeloId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsoId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnoFabricacao")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("AnoModelo")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("FlagZeroKm");

                    b.Property<decimal>("Franquia");

                    b.Property<int>("MarcaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Valor");

                    b.HasKey("ModeloId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Uso", b =>
                {
                    b.Property<int>("UsoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("UsoId");

                    b.ToTable("Usos");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.DistanciaTrabalho", b =>
                {
                    b.Property<int>("DistanciaTrabalhoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("DistanciaTrabalhoId");

                    b.ToTable("DistanciaTrabalho");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.EstadoCivil", b =>
                {
                    b.Property<int>("EstadoCivilId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("EstadoCivilId");

                    b.ToTable("EstadoCivil");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CotacaoId");

                    b.Property<string>("CpfPrincipalCondutor")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataNascPrincipalCondutor");

                    b.Property<int>("DistanciaTrabalhoId");

                    b.Property<int>("EstadoCivilId");

                    b.Property<bool>("FlagPontosCarteira");

                    b.Property<bool>("FlagResideMenorIdade");

                    b.Property<bool>("FlagSegPrincipalCondutor");

                    b.Property<string>("NomePrincipalCondutor")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("QuantidadeVeiculoId");

                    b.Property<int>("SexoId");

                    b.Property<int>("TempoHabilitacaoId");

                    b.Property<int>("TipoResidenciaId");

                    b.HasKey("Id");

                    b.HasIndex("CotacaoId")
                        .IsUnique();

                    b.HasIndex("DistanciaTrabalhoId");

                    b.HasIndex("EstadoCivilId");

                    b.HasIndex("QuantidadeVeiculoId");

                    b.HasIndex("SexoId");

                    b.HasIndex("TempoHabilitacaoId");

                    b.HasIndex("TipoResidenciaId");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.QuantidadeVeiculos", b =>
                {
                    b.Property<int>("QuantidadeVeiculoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("QuantidadeVeiculoId");

                    b.ToTable("QuantidadeVeiculos");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.Sexo", b =>
                {
                    b.Property<int>("SexoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("SexoId");

                    b.ToTable("Sexo");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.TempoHabilitacao", b =>
                {
                    b.Property<int>("TempoHabilitacaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("TempoHabilitacaoId");

                    b.ToTable("TempoHabilitacao");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.TipoResidencia", b =>
                {
                    b.Property<int>("TipoResidenciaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("TipoResidenciaId");

                    b.ToTable("TipoResidencia");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.AntiFurto", b =>
                {
                    b.Property<int>("AntiFurtoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("AntiFurtoId");

                    b.ToTable("AntiFurto");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.GararemFaculdade", b =>
                {
                    b.Property<int>("GaragemFaculdadeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("GaragemFaculdadeId");

                    b.ToTable("GaragemFaculdade");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.GararemResidencia", b =>
                {
                    b.Property<int>("GaragemResidenciaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("GaragemResidenciaId");

                    b.ToTable("GaragemResidencia");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.GararemTrabalho", b =>
                {
                    b.Property<int>("GaragemTrabalhoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("GaragemTrabalhoId");

                    b.ToTable("GaragemTrabalho");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.PropriedadeRastreador", b =>
                {
                    b.Property<int>("PropriedadeRastreadorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("PropriedadeRastreadorId");

                    b.ToTable("PropriedadeRastreador");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.Questionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AntiFurtoId");

                    b.Property<string>("CepPernoite")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<Guid>("CotacaoId");

                    b.Property<bool>("FlagAdaptadoDeficiente");

                    b.Property<bool>("FlagAlienado");

                    b.Property<bool>("FlagAntiFurto");

                    b.Property<bool>("FlagBlindado");

                    b.Property<bool>("FlagGararem");

                    b.Property<bool>("FlagKitGas");

                    b.Property<int?>("GaragemFaculdadeId");

                    b.Property<int?>("GararemResidenciaId");

                    b.Property<int?>("GararemTrabalhoId");

                    b.Property<int?>("PropriedadeRastreadorId");

                    b.Property<int?>("RastreadorId");

                    b.Property<int>("RelacaoSeguradoId");

                    b.HasKey("Id");

                    b.HasIndex("AntiFurtoId");

                    b.HasIndex("CotacaoId")
                        .IsUnique();

                    b.HasIndex("GaragemFaculdadeId");

                    b.HasIndex("GararemResidenciaId");

                    b.HasIndex("GararemTrabalhoId");

                    b.HasIndex("PropriedadeRastreadorId");

                    b.HasIndex("RastreadorId");

                    b.HasIndex("RelacaoSeguradoId");

                    b.ToTable("Questionarios");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.Rastreador", b =>
                {
                    b.Property<int>("RastreadorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("RastreadorId");

                    b.ToTable("Rastreadores");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.RelacaoSegurado", b =>
                {
                    b.Property<int>("RelacaoSeguradoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("RelacaoSeguradoId");

                    b.ToTable("RelacaoSegurado");
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ClienteRoot.Cliente", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.CotacaoRoot.Cotacao", "Cotacao")
                        .WithOne("Cliente")
                        .HasForeignKey("ExemploSeguros.Domain.Models.ClienteRoot.Cliente", "CotacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ClienteRoot.PaisResidencia", "PaisResidencia")
                        .WithMany("Clientes")
                        .HasForeignKey("PaisResidenciaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ClienteRoot.Profissao", "Profissao")
                        .WithMany("Clientes")
                        .HasForeignKey("ProfissaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ClienteRoot.Endereco", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.ClienteRoot.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("ExemploSeguros.Domain.Models.ClienteRoot.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CoberturasRoot.CoberturasItem", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.CoberturasRoot.Coberturas", "Coberturas")
                        .WithMany("CoberturasItems")
                        .HasForeignKey("CoberturaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Item", "Item")
                        .WithMany("Coberturas")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CoberturasRoot.CoberturasProduto", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.CoberturasRoot.Coberturas", "Coberturas")
                        .WithMany("CoberturasProduto")
                        .HasForeignKey("CoberturaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Produto", "Produtos")
                        .WithMany("CoberturasProduto")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.CotacaoRoot.Cotacao", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.CotacaoRoot.TipoCalculo", "TipoCalculo")
                        .WithMany("Cotacoes")
                        .HasForeignKey("TipoCalculoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.CotacaoRoot.TipoSeguro", "TipoSeguro")
                        .WithMany("Cotacoes")
                        .HasForeignKey("TipoSeguroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Item", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.CotacaoRoot.Cotacao", "Cotacao")
                        .WithOne("Item")
                        .HasForeignKey("ExemploSeguros.Domain.Models.ItemRoot.Item", "CotacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Imposto", "Imposto")
                        .WithMany("Itens")
                        .HasForeignKey("ImpostoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Uso", "Uso")
                        .WithMany("Itens")
                        .HasForeignKey("UsoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.ItemRoot.Modelo", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.ItemRoot.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.PerfilRoot.Perfil", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.CotacaoRoot.Cotacao", "Cotacao")
                        .WithOne("Perfil")
                        .HasForeignKey("ExemploSeguros.Domain.Models.PerfilRoot.Perfil", "CotacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.PerfilRoot.DistanciaTrabalho", "DistanciaTrabalho")
                        .WithMany("Perfis")
                        .HasForeignKey("DistanciaTrabalhoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.PerfilRoot.EstadoCivil", "EstadoCivil")
                        .WithMany("Perfis")
                        .HasForeignKey("EstadoCivilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.PerfilRoot.QuantidadeVeiculos", "QuantidadeVeiculos")
                        .WithMany("Perfis")
                        .HasForeignKey("QuantidadeVeiculoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.PerfilRoot.Sexo", "Sexo")
                        .WithMany("Perfis")
                        .HasForeignKey("SexoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.PerfilRoot.TempoHabilitacao", "TempoHabilitacao")
                        .WithMany("Perfis")
                        .HasForeignKey("TempoHabilitacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.PerfilRoot.TipoResidencia", "TipoResidencia")
                        .WithMany("Perfis")
                        .HasForeignKey("TipoResidenciaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExemploSeguros.Domain.Models.QuestionarioRoot.Questionario", b =>
                {
                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.AntiFurto", "AntiFurto")
                        .WithMany("Questionarios")
                        .HasForeignKey("AntiFurtoId");

                    b.HasOne("ExemploSeguros.Domain.Models.CotacaoRoot.Cotacao", "Cotacao")
                        .WithOne("Questionario")
                        .HasForeignKey("ExemploSeguros.Domain.Models.QuestionarioRoot.Questionario", "CotacaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.GararemFaculdade", "GararemFaculdade")
                        .WithMany("Questionarios")
                        .HasForeignKey("GaragemFaculdadeId");

                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.GararemResidencia", "GararemResidencia")
                        .WithMany("Questionarios")
                        .HasForeignKey("GararemResidenciaId");

                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.GararemTrabalho", "GararemTrabalho")
                        .WithMany("Questionarios")
                        .HasForeignKey("GararemTrabalhoId");

                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.PropriedadeRastreador", "PropriedadeRastreador")
                        .WithMany("Questionarios")
                        .HasForeignKey("PropriedadeRastreadorId");

                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.Rastreador", "Rastreador")
                        .WithMany("Questionarios")
                        .HasForeignKey("RastreadorId");

                    b.HasOne("ExemploSeguros.Domain.Models.QuestionarioRoot.RelacaoSegurado", "RelacaoSegurado")
                        .WithMany("Questionarios")
                        .HasForeignKey("RelacaoSeguradoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
