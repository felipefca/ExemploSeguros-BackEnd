using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;
using ExemploSeguros.Domain.Models.ItemRoot;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ExemploSegurosContext context) 
            : base(context)
        {
        }

        #region Item
        public Item ObterItemCotacao(Guid cotacaoId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = cn.Query<Item>("SELECT * FROM Itens WHERE CotacaoId = @CotacaoId",
                    new { CotacaoId = cotacaoId }).FirstOrDefault();
                return query;
            }
        }

        #endregion

        #region Uso
        public IEnumerable<Uso> ObterUsos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Usos";
                return cn.Query<Uso>(query);
            }
        }
        #endregion

        #region Imposto
        public IEnumerable<Imposto> ObterImpostos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Impostos";
                return cn.Query<Imposto>(query);
            }
        }
        #endregion

        #region Marca
        public Marca ObterMarcaPorId(int marcaId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var marca = cn.Query<Marca>("SELECT * FROM Marcas WHERE MarcaId = @MarcaId",
                    new { MarcaId = marcaId }).FirstOrDefault();
                return marca;
            }
        }

        public IEnumerable<Marca> ObterMarcas()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Marcas";
                return cn.Query<Marca>(query);
            }
        }

        public IEnumerable<Marca> ObterMarcasOrdenadasAlfabeticamente()
        {
            IEnumerable<Marca> query =  ObterMarcas().OrderBy(m => m.Nome);
            return query;
        }

        #endregion

        #region Modelo
        public IEnumerable<Modelo> ObterTodosModelosporMarca(int marcaId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                const string sqlModelo = @"SELECT * " +
                                         "  FROM Modelos m" +
                                         "  JOIN Marcas ma ON m.MarcaId = ma.MarcaId" +
                                         " WHERE m.MarcaId = @MarcaId";

                var modelo = cn.Query<Modelo, Marca, Modelo>(sqlModelo,
                    (m, ma) =>
                    {
                        m.Marca = ma;
                        return m;
                    },
                    new { MarcaId = marcaId }, splitOn: "ModeloId, MarcaId");

                return modelo;
            }
        }

        public IEnumerable<Modelo> ObterTodosModelosSelecionados(int marcaId, string modelo, string anoFabricao, string anoModelo,
            string zeroKm)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                const string sqlModelo = @"SELECT * " +
                                         "  FROM Modelos m" +
                                         "  JOIN Marcas ma ON m.MarcaId = ma.MarcaId" +
                                         " WHERE m.MarcaId = @MarcaId" +
                                         " AND m.Nome = @Modelo" +
                                         " AND m.AnoFabricacao = @AnoFabricacao" +
                                         " AND m.AnoModelo = @AnoModelo" +
                                         " AND m.FlagZeroKm = @FlagZeroKm";

                var modeloQuery = cn.Query<Modelo, Marca, Modelo>(sqlModelo,
                    (m, ma) =>
                    {
                        m.Marca = ma;
                        return m;
                    },
                    new
                    {
                        MarcaId = marcaId,
                        Modelo = modelo,
                        AnoFabricacao = anoFabricao,
                        AnoModelo = anoModelo,
                        FlagZeroKm = zeroKm
                    },
                    splitOn: "ModeloId, MarcaId");

                return modeloQuery;
            }
        }

        public Modelo ObterModeloPorId(int modeloId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                const string sqlModelo = @"SELECT ma.*, * " +
                                         "  FROM Modelos m" +
                                         "  JOIN Marcas ma ON m.MarcaId = ma.MarcaId" +
                                         " WHERE m.ModeloId = @ModeloId";

                var modeloQuery = cn.Query<Modelo, Marca, Modelo>(sqlModelo,
                    (m, ma) =>
                    {
                        m.Marca = ma;
                        return m;
                    },
                new { ModeloId = modeloId }, splitOn: "ModeloId, MarcaId");

                return modeloQuery.FirstOrDefault();
            }
        }

        public IEnumerable<Modelo> ObterModelos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Modelos";
                return cn.Query<Modelo>(query);
            }
        }

        public decimal ObterFranquiaModelo(int modeloId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                const string sqlModelo = @"SELECT ma.*, * " +
                                         "  FROM Modelos m" +
                                         "  JOIN Marcas ma ON m.MarcaId = ma.MarcaId" +
                                         " WHERE m.ModeloId = @ModeloId";

                var modeloQuery = cn.Query<Modelo, Marca, Modelo>(sqlModelo,
                    (m, ma) =>
                    {
                        m.Marca = ma;
                        return m;
                    },
                new { ModeloId = modeloId }, splitOn: "ModeloId, MarcaId");

                return modeloQuery.FirstOrDefault().Franquia;
            }
        }
        #endregion

        #region Produto
        public IEnumerable<Produto> ObterProdutos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Produtos";
                return cn.Query<Produto>(query);
            }
        }
        #endregion
    }
}