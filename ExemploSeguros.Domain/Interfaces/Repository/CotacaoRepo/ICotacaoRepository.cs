using ExemploSeguros.Domain.Models.CotacaoRoot;
using System;
using System.Collections.Generic;

namespace ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo
{
    public interface ICotacaoRepository : IRepository<Cotacao>
    {
        #region Cotação

        IEnumerable<Cotacao> ObterCotacoesPorUsuario(Guid userId);

        Cotacao ObterCotacaoPorId(Guid cotacaoId);

        #endregion

        #region Tipo de Cálculo

        IEnumerable<TipoCalculo> ObterTiposCalculo();

        TipoCalculo ObterTipoCalculoPorId(int tipoCalculoId);

        #endregion

        #region Tipo de Seguro

        IEnumerable<TipoSeguro> ObterTiposSeguro();

        #endregion
    }
}
