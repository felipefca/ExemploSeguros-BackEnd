using System;
using System.Collections.Generic;
using ExemploSeguros.Domain.Models.QuestionarioRoot;

namespace ExemploSeguros.Domain.Interfaces.Repository.QuestionarioRepo
{
    public interface IQuestionarioRepository : IRepository<Questionario>
    {
        #region Questionario
        Questionario ObterQuestionarioCotacao(Guid cotacaoId);

        #endregion

        #region Antifurto
        IEnumerable<AntiFurto> ObterAntiFurtos();
        #endregion

        #region GaragemFaculdade
        IEnumerable<GararemFaculdade> ObterGaragemFaculdades();
        #endregion

        #region GaragemTrabalho
        IEnumerable<GararemTrabalho> ObterGararemTrabalhos();
        #endregion

        #region GaragemResidencia
        IEnumerable<GararemResidencia> ObterGararemResidencias();
        #endregion

        #region PropriedadeRastreador
        IEnumerable<PropriedadeRastreador> ObterPropriedadeRastreadors();
        #endregion

        #region Rastreador
        IEnumerable<Rastreador> ObterRastreadores();
        #endregion

        #region RelacaoSegurado
        IEnumerable<RelacaoSegurado> ObterRelacaoSegurados();
        #endregion
    }
}