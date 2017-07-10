using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Commands.CotacaoCommand;

namespace ExemploSeguros.Application.Interfaces
{
    public interface ICotacaoAppService : IDisposable
    {
        RegistrarCotacaoCommand Adicionar(CotacaoViewModel cotacaoViewModel);

        void Atualizar(CotacaoViewModel cotacaoViewModel);

        void Remover(Guid id);

        CotacaoViewModel Validar(CotacaoViewModel cotacaoViewModel);

        IEnumerable<CotacaoViewModel> ObterCotacoesPorUsuario(Guid userId);

        CotacaoViewModel ObterCotacaoPorId(Guid cotacaoId);

        string GeneratorNumber();
    }
}