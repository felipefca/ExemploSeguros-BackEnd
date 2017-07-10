using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Interfaces.Repository.PerfilRepo;
using ExemploSeguros.Domain.Models.PerfilRoot;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public class PerfilRepository : Repository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(ExemploSegurosContext context) 
            : base(context)
        {
        }

        #region Perfil
        public Perfil ObterPerfilCotacao(Guid cotacaoId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = cn.Query<Perfil>("SELECT * FROM Perfis WHERE CotacaoId = @CotacaoId",
                    new { CotacaoId = cotacaoId }).FirstOrDefault();
                return query;
            }
        }
        #endregion

        #region DistanciaTrabalho
        public IEnumerable<DistanciaTrabalho> ObterDistancias()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from DistanciaTrabalho";
                return cn.Query<DistanciaTrabalho>(query);
            }
        }
        #endregion

        #region EstadoCivil
        public IEnumerable<EstadoCivil> ObterEstadoCivis()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from EstadoCivil";
                return cn.Query<EstadoCivil>(query);
            }
        }
        #endregion

        #region QuantidadeVeiculos
        public IEnumerable<QuantidadeVeiculos> ObterQuantidadeVeiculos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from QuantidadeVeiculos";
                return cn.Query<QuantidadeVeiculos>(query);
            }
        }
        #endregion

        #region Sexo
        public IEnumerable<Sexo> ObterSexos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Sexo";
                return cn.Query<Sexo>(query);
            }
        }
        #endregion

        #region TempoHabilitacao
        public IEnumerable<TempoHabilitacao> ObterTempoHabilitacao()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from TempoHabilitacao";
                return cn.Query<TempoHabilitacao>(query);
            }
        }

        #endregion

        #region
        public IEnumerable<TipoResidencia> ObterTipoResidencia()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from TipoResidencia";
                return cn.Query<TipoResidencia>(query);
            }
        }
        #endregion
    }
}