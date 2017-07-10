using System;
using System.Collections.Generic;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IPerfilAppService : IDisposable
    {
        #region Perfil
        PerfilViewModel ObterPerfilCotacao(Guid cotacaoId);
        #endregion

        #region DistanciaTrabalho
        IEnumerable<DistanciaTrabalhoViewModel> ObterDistancias();
        #endregion

        #region EstadoCivil
        IEnumerable<EstadoCivilViewModel> ObterEstadoCivis();
        #endregion

        #region QuantidadeVeiculos
        IEnumerable<QuantidadeVeiculosViewModel> ObterQuantidadeVeiculos();
        #endregion

        #region Sexo
        IEnumerable<SexoViewModel> ObterSexos();
        #endregion

        #region TempoHabilitação
        IEnumerable<TempoHabilitacaoViewModel> ObterTempoHabilitacao();
        #endregion

        #region TipoResidencia
        IEnumerable<TipoResidenciaViewModel> ObterTipoResidencia();
        #endregion
    }
}