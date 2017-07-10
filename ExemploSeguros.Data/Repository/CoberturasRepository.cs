using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Interfaces.Repository.CoberturasRepo;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public class CoberturasRepository : Repository<CoberturasItem>, ICoberturasRepository
    {
        public CoberturasRepository(ExemploSegurosContext context) 
            : base(context)
        {
        }

        #region Coberturas
        public IEnumerable<Coberturas> ObterCoberturasProdutos(int produto)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var coberturas = cn.Query<Coberturas, CoberturasProduto, Coberturas>
                ("SELECT cp.*, * " +
                 "  FROM Coberturas c" +
                 "  JOIN CoberturasProduto cp ON c.CoberturaId = cp.CoberturaId" +
                 "  WHERE cp.ProdutoId = @ProdutoId",
                    (c, cp) =>
                    {
                        cp.Coberturas = c;
                        return c;
                    },
                    new {ProdutoId = produto}, splitOn: "CoberturaId, CoberturaProdutoId");

                return coberturas;
            }
        }
        #endregion

        #region CoberturasProduto
        public CoberturasProduto ObterCoberturaProdutos(int produto, int coberturaId)
        {
            using (var cn =  Db.Database.GetDbConnection())
            {
                var coberturas = cn.Query<CoberturasProduto>("SELECT * FROM CoberturasProduto WHERE ProdutoId = @ProdutoId AND CoberturaId = @CoberturaId",
                    new { ProdutoId = produto, CoberturaId = coberturaId });
                return coberturas.FirstOrDefault(); 
            }
        }

        public IEnumerable<CoberturasProduto> ObterCoberturas(int produto)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var coberturas = cn.Query<CoberturasProduto>("SELECT * FROM CoberturasProduto WHERE ProdutoId = @ProdutoId",
                    new { ProdutoId = produto});
                return coberturas;
            }
        }

        #endregion

        #region CoberturasItem
        public IEnumerable<CoberturasItem> ObterCoberturasItems(Guid itemId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = cn.Query<CoberturasItem, Item, Coberturas, CoberturasItem>
                ("SELECT * " +
                 "  FROM itemcoberturas it" +
                 "  JOIN Itens i ON it.ItemId = i.ItemId" +
                 "  JOIN Coberturas c ON it.CoberturaId = c.CoberturaId" +
                 "  WHERE it.ItemId = @ItemId",
                    (it, i, c) =>
                    {
                        it.AtribuirItem(i);
                        it.AtribuirCoberturas(c);
                        return it;
                    },
                    new { ItemId = itemId }, splitOn: "CoberturasItemId, ItemId, CoberturaId");

                return query;
            }
        }
        #endregion
    }
}