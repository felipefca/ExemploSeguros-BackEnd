using System;
using System.Collections.Generic;
using ExemploSeguros.Domain.Models.CoberturasRoot;

namespace ExemploSeguros.Domain.Interfaces.Repository.CoberturasRepo
{
    public interface ICoberturasRepository : IRepository<CoberturasItem>
    {
        #region Coberturas
        IEnumerable<Coberturas> ObterCoberturasProdutos(int produto);
        #endregion

        #region CoberturaProduto
        CoberturasProduto ObterCoberturaProdutos(int produto, int coberturaId);
        IEnumerable<CoberturasProduto> ObterCoberturas(int produto);
        #endregion

        #region CoberturaItem
        IEnumerable<CoberturasItem> ObterCoberturasItems(Guid itemId);
        #endregion
    }
}