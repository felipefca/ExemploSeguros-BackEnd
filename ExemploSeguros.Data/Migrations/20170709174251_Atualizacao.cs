using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExemploSeguros.Data.Migrations
{
    public partial class Atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    PaisResidenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.PaisResidenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Profissoes",
                columns: table => new
                {
                    ProfissaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissoes", x => x.ProfissaoId);
                });

            migrationBuilder.CreateTable(
                name: "Coberturas",
                columns: table => new
                {
                    CoberturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    Info = table.Column<string>(type: "varchar(1500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coberturas", x => x.CoberturaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoCalculo",
                columns: table => new
                {
                    TipoCalculoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCalculo", x => x.TipoCalculoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoSeguro",
                columns: table => new
                {
                    TipoSeguroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSeguro", x => x.TipoSeguroId);
                });

            migrationBuilder.CreateTable(
                name: "Impostos",
                columns: table => new
                {
                    ImpostoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impostos", x => x.ImpostoId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imagem = table.Column<string>(type: "varchar(150)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Usos",
                columns: table => new
                {
                    UsoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usos", x => x.UsoId);
                });

            migrationBuilder.CreateTable(
                name: "DistanciaTrabalho",
                columns: table => new
                {
                    DistanciaTrabalhoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistanciaTrabalho", x => x.DistanciaTrabalhoId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    EstadoCivilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.EstadoCivilId);
                });

            migrationBuilder.CreateTable(
                name: "QuantidadeVeiculos",
                columns: table => new
                {
                    QuantidadeVeiculoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantidadeVeiculos", x => x.QuantidadeVeiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    SexoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.SexoId);
                });

            migrationBuilder.CreateTable(
                name: "TempoHabilitacao",
                columns: table => new
                {
                    TempoHabilitacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempoHabilitacao", x => x.TempoHabilitacaoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoResidencia",
                columns: table => new
                {
                    TipoResidenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoResidencia", x => x.TipoResidenciaId);
                });

            migrationBuilder.CreateTable(
                name: "AntiFurto",
                columns: table => new
                {
                    AntiFurtoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntiFurto", x => x.AntiFurtoId);
                });

            migrationBuilder.CreateTable(
                name: "GaragemFaculdade",
                columns: table => new
                {
                    GaragemFaculdadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaragemFaculdade", x => x.GaragemFaculdadeId);
                });

            migrationBuilder.CreateTable(
                name: "GaragemResidencia",
                columns: table => new
                {
                    GaragemResidenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaragemResidencia", x => x.GaragemResidenciaId);
                });

            migrationBuilder.CreateTable(
                name: "GaragemTrabalho",
                columns: table => new
                {
                    GaragemTrabalhoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaragemTrabalho", x => x.GaragemTrabalhoId);
                });

            migrationBuilder.CreateTable(
                name: "PropriedadeRastreador",
                columns: table => new
                {
                    PropriedadeRastreadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropriedadeRastreador", x => x.PropriedadeRastreadorId);
                });

            migrationBuilder.CreateTable(
                name: "Rastreadores",
                columns: table => new
                {
                    RastreadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rastreadores", x => x.RastreadorId);
                });

            migrationBuilder.CreateTable(
                name: "RelacaoSegurado",
                columns: table => new
                {
                    RelacaoSeguradoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacaoSegurado", x => x.RelacaoSeguradoId);
                });

            migrationBuilder.CreateTable(
                name: "Cotacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataCalculo = table.Column<DateTime>(nullable: false),
                    DataVigenciaFinal = table.Column<DateTime>(nullable: false),
                    DataVigenciaInicial = table.Column<DateTime>(nullable: false),
                    NumCotacao = table.Column<int>(nullable: false),
                    PremioTotal = table.Column<decimal>(nullable: false),
                    TipoCalculoId = table.Column<int>(nullable: false),
                    TipoSeguroId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotacoes_TipoCalculo_TipoCalculoId",
                        column: x => x.TipoCalculoId,
                        principalTable: "TipoCalculo",
                        principalColumn: "TipoCalculoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cotacoes_TipoSeguro_TipoSeguroId",
                        column: x => x.TipoSeguroId,
                        principalTable: "TipoSeguro",
                        principalColumn: "TipoSeguroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    ModeloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnoFabricacao = table.Column<string>(type: "varchar(10)", nullable: false),
                    AnoModelo = table.Column<string>(type: "varchar(10)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false),
                    FlagZeroKm = table.Column<bool>(nullable: false),
                    Franquia = table.Column<decimal>(nullable: false),
                    MarcaId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.ModeloId);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoberturasProduto",
                columns: table => new
                {
                    CoberturaProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoberturaId = table.Column<int>(nullable: false),
                    FlagBasica = table.Column<bool>(nullable: false),
                    FlagObrigatorio = table.Column<bool>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Taxa = table.Column<double>(nullable: false),
                    ValorMaximo = table.Column<float>(nullable: true),
                    ValorMinimo = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoberturasProduto", x => x.CoberturaProdutoId);
                    table.ForeignKey(
                        name: "FK_CoberturasProduto_Coberturas_CoberturaId",
                        column: x => x.CoberturaId,
                        principalTable: "Coberturas",
                        principalColumn: "CoberturaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoberturasProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CotacaoId = table.Column<Guid>(nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    PaisResidenciaId = table.Column<int>(nullable: false),
                    ProfissaoId = table.Column<int>(nullable: false),
                    Rg = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false),
                    SobreNome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Cotacoes_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Paises_PaisResidenciaId",
                        column: x => x.PaisResidenciaId,
                        principalTable: "Paises",
                        principalColumn: "PaisResidenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Profissoes_ProfissaoId",
                        column: x => x.ProfissaoId,
                        principalTable: "Profissoes",
                        principalColumn: "ProfissaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CotacaoId = table.Column<Guid>(nullable: false),
                    CpfPrincipalCondutor = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    DataNascPrincipalCondutor = table.Column<DateTime>(nullable: false),
                    DistanciaTrabalhoId = table.Column<int>(nullable: false),
                    EstadoCivilId = table.Column<int>(nullable: false),
                    FlagPontosCarteira = table.Column<bool>(nullable: false),
                    FlagResideMenorIdade = table.Column<bool>(nullable: false),
                    FlagSegPrincipalCondutor = table.Column<bool>(nullable: false),
                    NomePrincipalCondutor = table.Column<string>(type: "varchar(50)", nullable: false),
                    QuantidadeVeiculoId = table.Column<int>(nullable: false),
                    SexoId = table.Column<int>(nullable: false),
                    TempoHabilitacaoId = table.Column<int>(nullable: false),
                    TipoResidenciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfis_Cotacoes_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfis_DistanciaTrabalho_DistanciaTrabalhoId",
                        column: x => x.DistanciaTrabalhoId,
                        principalTable: "DistanciaTrabalho",
                        principalColumn: "DistanciaTrabalhoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfis_EstadoCivil_EstadoCivilId",
                        column: x => x.EstadoCivilId,
                        principalTable: "EstadoCivil",
                        principalColumn: "EstadoCivilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfis_QuantidadeVeiculos_QuantidadeVeiculoId",
                        column: x => x.QuantidadeVeiculoId,
                        principalTable: "QuantidadeVeiculos",
                        principalColumn: "QuantidadeVeiculoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfis_Sexo_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexo",
                        principalColumn: "SexoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfis_TempoHabilitacao_TempoHabilitacaoId",
                        column: x => x.TempoHabilitacaoId,
                        principalTable: "TempoHabilitacao",
                        principalColumn: "TempoHabilitacaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfis_TipoResidencia_TipoResidenciaId",
                        column: x => x.TipoResidenciaId,
                        principalTable: "TipoResidencia",
                        principalColumn: "TipoResidenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AntiFurtoId = table.Column<int>(nullable: true),
                    CepPernoite = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    CotacaoId = table.Column<Guid>(nullable: false),
                    FlagAdaptadoDeficiente = table.Column<bool>(nullable: false),
                    FlagAlienado = table.Column<bool>(nullable: false),
                    FlagAntiFurto = table.Column<bool>(nullable: false),
                    FlagBlindado = table.Column<bool>(nullable: false),
                    FlagGararem = table.Column<bool>(nullable: false),
                    FlagKitGas = table.Column<bool>(nullable: false),
                    GaragemFaculdadeId = table.Column<int>(nullable: true),
                    GararemResidenciaId = table.Column<int>(nullable: true),
                    GararemTrabalhoId = table.Column<int>(nullable: true),
                    PropriedadeRastreadorId = table.Column<int>(nullable: true),
                    RastreadorId = table.Column<int>(nullable: true),
                    RelacaoSeguradoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionarios_AntiFurto_AntiFurtoId",
                        column: x => x.AntiFurtoId,
                        principalTable: "AntiFurto",
                        principalColumn: "AntiFurtoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_Cotacoes_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questionarios_GaragemFaculdade_GaragemFaculdadeId",
                        column: x => x.GaragemFaculdadeId,
                        principalTable: "GaragemFaculdade",
                        principalColumn: "GaragemFaculdadeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_GaragemResidencia_GararemResidenciaId",
                        column: x => x.GararemResidenciaId,
                        principalTable: "GaragemResidencia",
                        principalColumn: "GaragemResidenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_GaragemTrabalho_GararemTrabalhoId",
                        column: x => x.GararemTrabalhoId,
                        principalTable: "GaragemTrabalho",
                        principalColumn: "GaragemTrabalhoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_PropriedadeRastreador_PropriedadeRastreadorId",
                        column: x => x.PropriedadeRastreadorId,
                        principalTable: "PropriedadeRastreador",
                        principalColumn: "PropriedadeRastreadorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_Rastreadores_RastreadorId",
                        column: x => x.RastreadorId,
                        principalTable: "Rastreadores",
                        principalColumn: "RastreadorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_RelacaoSegurado_RelacaoSeguradoId",
                        column: x => x.RelacaoSeguradoId,
                        principalTable: "RelacaoSegurado",
                        principalColumn: "RelacaoSeguradoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CotacaoId = table.Column<Guid>(nullable: false),
                    DataSaida = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    FlagRemarcado = table.Column<bool>(nullable: false),
                    ImpostoId = table.Column<int>(nullable: false),
                    ModeloId = table.Column<int>(nullable: false),
                    NumChassi = table.Column<long>(nullable: true),
                    Odometro = table.Column<int>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: false),
                    UsoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itens_Cotacoes_CotacaoId",
                        column: x => x.CotacaoId,
                        principalTable: "Cotacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_Impostos_ImpostoId",
                        column: x => x.ImpostoId,
                        principalTable: "Impostos",
                        principalColumn: "ImpostoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_Modelos_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelos",
                        principalColumn: "ModeloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_Usos_UsoId",
                        column: x => x.UsoId,
                        principalTable: "Usos",
                        principalColumn: "UsoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ClienteId = table.Column<Guid>(nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCoberturas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CoberturaId = table.Column<int>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCoberturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCoberturas_Coberturas_CoberturaId",
                        column: x => x.CoberturaId,
                        principalTable: "Coberturas",
                        principalColumn: "CoberturaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCoberturas_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CotacaoId",
                table: "Clientes",
                column: "CotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PaisResidenciaId",
                table: "Clientes",
                column: "PaisResidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProfissaoId",
                table: "Clientes",
                column: "ProfissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemCoberturas_CoberturaId",
                table: "ItemCoberturas",
                column: "CoberturaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCoberturas_ItemId",
                table: "ItemCoberturas",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CoberturasProduto_CoberturaId",
                table: "CoberturasProduto",
                column: "CoberturaId");

            migrationBuilder.CreateIndex(
                name: "IX_CoberturasProduto_ProdutoId",
                table: "CoberturasProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacoes_TipoCalculoId",
                table: "Cotacoes",
                column: "TipoCalculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacoes_TipoSeguroId",
                table: "Cotacoes",
                column: "TipoSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_CotacaoId",
                table: "Itens",
                column: "CotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_ImpostoId",
                table: "Itens",
                column: "ImpostoId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_ModeloId",
                table: "Itens",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_ProdutoId",
                table: "Itens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_UsoId",
                table: "Itens",
                column: "UsoId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_CotacaoId",
                table: "Perfis",
                column: "CotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_DistanciaTrabalhoId",
                table: "Perfis",
                column: "DistanciaTrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_EstadoCivilId",
                table: "Perfis",
                column: "EstadoCivilId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_QuantidadeVeiculoId",
                table: "Perfis",
                column: "QuantidadeVeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_SexoId",
                table: "Perfis",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_TempoHabilitacaoId",
                table: "Perfis",
                column: "TempoHabilitacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_TipoResidenciaId",
                table: "Perfis",
                column: "TipoResidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_AntiFurtoId",
                table: "Questionarios",
                column: "AntiFurtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_CotacaoId",
                table: "Questionarios",
                column: "CotacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_GaragemFaculdadeId",
                table: "Questionarios",
                column: "GaragemFaculdadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_GararemResidenciaId",
                table: "Questionarios",
                column: "GararemResidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_GararemTrabalhoId",
                table: "Questionarios",
                column: "GararemTrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_PropriedadeRastreadorId",
                table: "Questionarios",
                column: "PropriedadeRastreadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_RastreadorId",
                table: "Questionarios",
                column: "RastreadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_RelacaoSeguradoId",
                table: "Questionarios",
                column: "RelacaoSeguradoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "ItemCoberturas");

            migrationBuilder.DropTable(
                name: "CoberturasProduto");

            migrationBuilder.DropTable(
                name: "Perfis");

            migrationBuilder.DropTable(
                name: "Questionarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Coberturas");

            migrationBuilder.DropTable(
                name: "DistanciaTrabalho");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "QuantidadeVeiculos");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "TempoHabilitacao");

            migrationBuilder.DropTable(
                name: "TipoResidencia");

            migrationBuilder.DropTable(
                name: "AntiFurto");

            migrationBuilder.DropTable(
                name: "GaragemFaculdade");

            migrationBuilder.DropTable(
                name: "GaragemResidencia");

            migrationBuilder.DropTable(
                name: "GaragemTrabalho");

            migrationBuilder.DropTable(
                name: "PropriedadeRastreador");

            migrationBuilder.DropTable(
                name: "Rastreadores");

            migrationBuilder.DropTable(
                name: "RelacaoSegurado");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Profissoes");

            migrationBuilder.DropTable(
                name: "Cotacoes");

            migrationBuilder.DropTable(
                name: "Impostos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usos");

            migrationBuilder.DropTable(
                name: "TipoCalculo");

            migrationBuilder.DropTable(
                name: "TipoSeguro");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
