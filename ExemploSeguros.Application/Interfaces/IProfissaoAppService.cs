using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IProfissaoAppService : IDisposable
    {
        IEnumerable<ProfissaoViewModel> ObterTodasProfissoes();
    }
}