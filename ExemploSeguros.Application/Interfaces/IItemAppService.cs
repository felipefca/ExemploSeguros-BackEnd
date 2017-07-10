using System;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IItemAppService : IDisposable
    {
        ItemViewModel ObterItemCotacao(Guid cotacaoId);
    }
}