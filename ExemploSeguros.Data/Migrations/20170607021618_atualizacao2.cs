using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExemploSeguros.Data.Migrations
{
    public partial class atualizacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GararemTrabalhoId",
                table: "GaragemTrabalho",
                newName: "GaragemTrabalhoId");

            migrationBuilder.RenameColumn(
                name: "GararemResidenciaId",
                table: "GaragemResidencia",
                newName: "GaragemResidenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GaragemTrabalhoId",
                table: "GaragemTrabalho",
                newName: "GararemTrabalhoId");

            migrationBuilder.RenameColumn(
                name: "GaragemResidenciaId",
                table: "GaragemResidencia",
                newName: "GararemResidenciaId");
        }
    }
}
