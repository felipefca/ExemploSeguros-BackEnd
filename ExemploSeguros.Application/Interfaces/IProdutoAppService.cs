using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IProdutoAppService : IDisposable
    {
        IEnumerable<ProdutoViewModel> ObterProdutos();
    }
}