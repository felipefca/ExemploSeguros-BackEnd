using System;
using System.Collections.Generic;
using ExemploSeguros.Domain.Models.ItemRoot;

namespace ExemploSeguros.Domain.Interfaces.Repository.ItemRepo
{
    public interface IItemRepository : IRepository<Item>
    {
        #region Item

        Item ObterItemCotacao(Guid cotacaoId);

        #endregion

        #region Uso

        IEnumerable<Uso> ObterUsos();

        #endregion

        #region Imposto

        IEnumerable<Imposto> ObterImpostos();

        #endregion

        #region Marca

        IEnumerable<Marca> ObterMarcas();

        Marca ObterMarcaPorId(int marcaId);

        IEnumerable<Marca> ObterMarcasOrdenadasAlfabeticamente();

        #endregion

        #region Modelo

        IEnumerable<Modelo> ObterModelos();

        IEnumerable<Modelo> ObterTodosModelosporMarca(int marcaId);

        IEnumerable<Modelo> ObterTodosModelosSelecionados(int marcaId, string modelo, string anoFabricao, string anoModelo,
            string zeroKm);

        Modelo ObterModeloPorId(int modeloId);

        decimal ObterFranquiaModelo(int modeloId);

        #endregion

        #region Produto

        IEnumerable<Produto> ObterProdutos();

        #endregion
    }
}