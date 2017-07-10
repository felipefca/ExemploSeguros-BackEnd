using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IQuestionarioAppService : IDisposable
    {
        #region Questionario
        QuestionarioViewModel ObterQuestionarioCotacao(Guid cotacaoId);

        #endregion

        #region Antifurto
        IEnumerable<AntiFurtoViewModel> ObterAntiFurtos();
        #endregion

        #region GaragemFaculdade
        IEnumerable<GararemFaculdadeViewModel> ObterGaragemFaculdades();
        #endregion

        #region GaragemTrabalho
        IEnumerable<GararemTrabalhoViewModel> ObterGararemTrabalhos();
        #endregion

        #region GaragemResidencia
        IEnumerable<GararemResidenciaViewModel> ObterGararemResidencias();
        #endregion

        #region PropriedadeRastreador
        IEnumerable<PropriedadeRastreadorViewModel> ObterPropriedadeRastreadors();
        #endregion

        #region Rastreador
        IEnumerable<RastreadorViewModel> ObterRastreadores();
        #endregion

        #region RelacaoSegurado
        IEnumerable<RelacaoSeguradoViewModel> ObterRelacaoSegurados();
        #endregion
    }
}