using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Interfaces.Repository.ClienteRepo;
using ExemploSeguros.Domain.Models.ClienteRoot;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ExemploSegurosContext context)
            : base(context)
        {
        }

        #region Cliente
        public override IEnumerable<Cliente> ObterTodos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var cliente = cn.Query<Cliente, Profissao, PaisResidencia, Cliente>
                    ("SELECT * " +
                     "  FROM Clientes c" +
                     "  JOIN Profissoes p ON c.ProfissaoId = p.ProfissaoId" +
                     "  JOIN Paises ps ON c.PaisResidenciaId = ps.PaisResidenciaId",
                        (c, p, ps) =>
                        {
                            c.AtribuirProfissoes(p);
                            c.AtribuirPaises(ps);
                            return c;
                        },
                        splitOn: "Id, ProfissaoId, PaisResidenciaId");

                return cliente;
            }
        }

        public override Cliente ObterPorId(Guid id)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var sqlCliente = @"SELECT * " +
                         "  FROM Clientes c" +
                         "  LEFT JOIN Enderecos e ON e.ClienteId = c.Id" +
                         " WHERE c.Id = @ClienteId";

                var cliente = cn.Query<Cliente, Endereco, Cliente>(sqlCliente,
                        (c, e) =>
                        {
                            c.AtribuirEndereco(e);
                            return c;
                        },
                        new { ClienteId = id });

                return cliente.FirstOrDefault();
            }
        }

        public Cliente ObterClienteCotacao(Guid cotacaoId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                const string sql = @"SELECT * " +
                                     "  FROM Clientes c" +
                                     "  LEFT JOIN Enderecos e ON e.ClienteId = c.Id" +
                                     " WHERE c.CotacaoId = @CotacaoId";

                var query = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) =>
                    {
                        c.AtribuirEndereco(e);
                        return c;
                    },
                new { CotacaoId = cotacaoId });

                return query.FirstOrDefault();
            }
        }
        #endregion

        #region Endereco
        public Endereco ObterEnderecoCliente(Guid clienteId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = cn.Query<Endereco>("SELECT * FROM Enderecos WHERE Id = @ClienteId",
                    new { ClienteId = clienteId }).FirstOrDefault();
                return query;
            }
        }
        #endregion

        #region Pais de Residencia
        public IEnumerable<PaisResidencia> ObterPaises()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Paises";
                return cn.Query<PaisResidencia>(query);
            }
        }
        #endregion

        #region Profissao
        public IEnumerable<Profissao> ObterProfissoes()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Profissoes";
                return cn.Query<Profissao>(query);
            }
        }
        #endregion
    }
}