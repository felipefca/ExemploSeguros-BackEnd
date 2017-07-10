using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExemploSeguros.Data.Migrations
{
    public partial class atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    GararemResidenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaragemResidencia", x => x.GararemResidenciaId);
                });

            migrationBuilder.CreateTable(
                name: "GaragemTrabalho",
                columns: table => new
                {
                    GararemTrabalhoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaragemTrabalho", x => x.GararemTrabalhoId);
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
                        principalColumn: "GararemResidenciaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionarios_GaragemTrabalho_GararemTrabalhoId",
                        column: x => x.GararemTrabalhoId,
                        principalTable: "GaragemTrabalho",
                        principalColumn: "GararemTrabalhoId",
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
                name: "Questionarios");

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
        }
    }
}
