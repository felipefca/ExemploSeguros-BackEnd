using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface ICoberturasAppService : IDisposable
    {
        #region CoberturaProduto
        IEnumerable<CoberturasViewModel> ObterCoberturasProdutos(int produto);
        CoberturasViewModel ObterCoberturaProdutos(int produto, int coberturaId);

        int ObterIdCoberturaBasica(int produto);
        #endregion

        #region CoberturaItem
        IEnumerable<CoberturaItemViewModel> ObterCoberturasItems(Guid itemId);
        #endregion
    }
}