using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface ITipoCalculoAppService : IDisposable
    {
        IEnumerable<TipoCalculoViewModel> ObterTiposCalculo();

        TipoCalculoViewModel ObterTipoCalculoPorId(int tipoCalculoId);
    }
}