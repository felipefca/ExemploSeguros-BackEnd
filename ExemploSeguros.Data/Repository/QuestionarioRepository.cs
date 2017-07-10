using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Interfaces.Repository.QuestionarioRepo;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public class QuestionarioRepository : Repository<Questionario>, IQuestionarioRepository
    {
        public QuestionarioRepository(ExemploSegurosContext context) 
            : base(context)
        {
        }

        #region Questionario
        public Questionario ObterQuestionarioCotacao(Guid cotacaoId)
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = cn.Query<Questionario>("SELECT * FROM Questionarios WHERE CotacaoId = @CotacaoId",
                    new { CotacaoId = cotacaoId }).FirstOrDefault();
                return query;
            }
        }
        #endregion

        #region AntiFurto
        public IEnumerable<AntiFurto> ObterAntiFurtos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from AntiFurto";
                return cn.Query<AntiFurto>(query);
            }
        }
        #endregion

        #region GaragemFaculdade
        public IEnumerable<GararemFaculdade> ObterGaragemFaculdades()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from GaragemFaculdade";
                return cn.Query<GararemFaculdade>(query);
            }
        }
        #endregion

        #region GaragemTrabalho
        public IEnumerable<GararemTrabalho> ObterGararemTrabalhos()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from GaragemTrabalho";
                return cn.Query<GararemTrabalho>(query);
            }
        }
        #endregion

        #region GaragemResidencia
        public IEnumerable<GararemResidencia> ObterGararemResidencias()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from GaragemResidencia";
                return cn.Query<GararemResidencia>(query);
            }
        }
        #endregion

        #region PropriedadeRastreador
        public IEnumerable<PropriedadeRastreador> ObterPropriedadeRastreadors()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from PropriedadeRastreador";
                return cn.Query<PropriedadeRastreador>(query);
            }
        }
        #endregion

        #region Rastreador
        public IEnumerable<Rastreador> ObterRastreadores()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from Rastreadores";
               return cn.Query<Rastreador>(query);
            }
        }
        #endregion

        #region RelacaoSegurado
        public IEnumerable<RelacaoSegurado> ObterRelacaoSegurados()
        {
            using (var cn = Db.Database.GetDbConnection())
            {
                var query = @"Select * from RelacaoSegurado";
                return cn.Query<RelacaoSegurado>(query);
            }
        }
        #endregion
    }
}