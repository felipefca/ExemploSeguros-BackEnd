using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IMarcaAppService : IDisposable
    {
        MarcaViewModel ObterMarcaPorId(int marcaId);

        IEnumerable<MarcaViewModel> ObterMarcas();

        IEnumerable<MarcaViewModel> ObterMarcasOrdenadasAlfabeticamente();
    }
}