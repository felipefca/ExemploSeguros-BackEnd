using System;
using System.Collections.Generic;
using ExemploSeguros.Domain.Models.PerfilRoot;

namespace ExemploSeguros.Domain.Interfaces.Repository.PerfilRepo
{
    public interface IPerfilRepository : IRepository<Perfil>
    {
        #region Perfil
        Perfil ObterPerfilCotacao(Guid cotacaoId);
        #endregion

        #region DistanciaTrabalho
        IEnumerable<DistanciaTrabalho> ObterDistancias();
        #endregion

        #region EstadoCivil
        IEnumerable<EstadoCivil> ObterEstadoCivis();
        #endregion

        #region QuantidadeVeiculos
        IEnumerable<QuantidadeVeiculos> ObterQuantidadeVeiculos();
        #endregion

        #region Sexo
        IEnumerable<Sexo> ObterSexos();
        #endregion

        #region TempoHabilitação
        IEnumerable<TempoHabilitacao> ObterTempoHabilitacao();
        #endregion

        #region TipoResidencia
        IEnumerable<TipoResidencia> ObterTipoResidencia();
        #endregion
    }
}