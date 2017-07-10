using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo;
using ExemploSeguros.Domain.Models.ClienteRoot;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Models.PerfilRoot;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public class CotacaoRepository : Repository<Cotacao>, ICotacaoRepository
    {
        public CotacaoRepository(ExemploSegurosContext context)
            : base(context)
        {
        }

        #region Cotação
        public Cotacao ObterCotacaoPorId(Guid cotacaoId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"SELECT * " +
                             "  FROM Cotacoes x" +
                             "  INNER JOIN Itens i ON i.CotacaoId = x.Id" +
                             "  INNER JOIN Clientes c ON c.CotacaoId = x.Id" +
                             "  LEFT JOIN Enderecos e ON e.ClienteId = c.Id" +
                             "  INNER JOIN Perfis p ON p.CotacaoId = x.Id" +
                             "  INNER JOIN Questionarios q ON q.CotacaoId = x.Id" +
                             " WHERE x.Id = @CotacaoId";

                var cotacao = cn.Query<Cotacao, Item, Cliente, Endereco, Perfil, Questionario, Cotacao>(query,
                        (x, i, c, e, p, q) =>
                        {
                            x.AtribuirItem(i);
                            x.AtribuirCliente(c);
                            x.Cliente.AtribuirEndereco(e);
                            x.AtribuirPerfil(p);
                            x.AtribuirQuestioario(q);
                            return x;
                        },
                        new { CotacaoId = cotacaoId }).FirstOrDefault();

                return cotacao;
            }
        }

        public IEnumerable<Cotacao> ObterCotacoesPorUsuario(Guid userId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"SELECT * " +
                             "  FROM Cotacoes x" +
                             "  INNER JOIN Itens i ON i.CotacaoId = x.Id" +
                             "  INNER JOIN Clientes c ON c.CotacaoId = x.Id" +
                             "  LEFT JOIN Enderecos e ON e.ClienteId = c.Id" +
                             "  INNER JOIN Perfis p ON p.CotacaoId = x.Id" +
                             "  INNER JOIN Questionarios q ON q.CotacaoId = x.Id" +
                             " WHERE x.UserId = @UserId";

                var cotacao = cn.Query<Cotacao, Item, Cliente, Endereco, Perfil, Questionario, Cotacao>(query,
                        (x, i, c, e, p, q) =>
                        {
                            x.AtribuirItem(i);
                            x.AtribuirCliente(c);
                            x.Cliente.AtribuirEndereco(e);
                            x.AtribuirPerfil(p);
                            x.AtribuirQuestioario(q);
                            return x;
                        },
                        new { UserId = userId });

                return cotacao;
                //var cotacao = cn.Query<Cotacao>("SELECT * FROM Cotacoes WHERE UserId = @UserId",
                //    new { UserId = userId });
                //return cotacao;
            }
        }
        #endregion

        #region Tipo de Cálculo
        public TipoCalculo ObterTipoCalculoPorId(int tipoCalculoId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = cn.Query<TipoCalculo>("SELECT * FROM TipoCalculo WHERE TipoCalculoId = @TipoCalculoId",
                    new { TipoCalculoId = tipoCalculoId }).FirstOrDefault();
                return query;
            }
        }

        public IEnumerable<TipoCalculo> ObterTiposCalculo()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from TipoCalculo";
                return cn.Query<TipoCalculo>(query);
            }
        }
        #endregion

        #region Tipo de Seguro
        public IEnumerable<TipoSeguro> ObterTiposSeguro()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from TipoSeguro";
                return cn.Query<TipoSeguro>(query);
            }
        }
        #endregion
    }
}