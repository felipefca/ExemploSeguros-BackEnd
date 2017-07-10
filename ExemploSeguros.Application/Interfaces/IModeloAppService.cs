using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IModeloAppService : IDisposable
    {
        IEnumerable<ModeloViewModel> ObterModelos();

        IEnumerable<ModeloViewModel> ObterTodosModelosporMarca(int marcaId);

        IEnumerable<ModeloViewModel> ObterTodosModelosSelecionados(int marcaId, string modelo, string anoFabricao, string anoModelo,
            string zeroKm);

        IEnumerable<ModeloViewModel> ObterTodosModelosSelecionadosOrdenadamente(int marcaId, string modelo,
            string anoFabricao, string anoModelo,
            string zeroKm);

        ModeloViewModel ObterModeloPorId(int modeloId);

        List<string> ObterNomeModelosPorMarca(int marcaId);

        decimal ObterValorModelo(int modeloId);

        decimal ObterFranquiaModelo(int modeloId);
    }
}