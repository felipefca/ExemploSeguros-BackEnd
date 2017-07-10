using System;
using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.PerfilRepo;

namespace ExemploSeguros.Application.Services
{
    public class PerfilAppService : IPerfilAppService
    {
        private readonly IMapper _mapper;
        private readonly IPerfilRepository _perfilRepository;

        public PerfilAppService(IMapper mapper, IPerfilRepository perfilRepository)
        {
            _mapper = mapper;
            _perfilRepository = perfilRepository;
        }

        #region Perfil
        public PerfilViewModel ObterPerfilCotacao(Guid cotacaoId)
        {
            return _mapper.Map<PerfilViewModel>(_perfilRepository.ObterPerfilCotacao(cotacaoId));
        }
        #endregion

        #region DistanciaTrabalho
        public IEnumerable<DistanciaTrabalhoViewModel> ObterDistancias()
        {
            return _mapper.Map<IEnumerable<DistanciaTrabalhoViewModel>>(_perfilRepository.ObterDistancias());
        }
        #endregion

        #region EstadoCivil
        public IEnumerable<EstadoCivilViewModel> ObterEstadoCivis()
        {
            return _mapper.Map<IEnumerable<EstadoCivilViewModel>>(_perfilRepository.ObterEstadoCivis());
        }
        #endregion

        #region QuantidadeVeiculos
        public IEnumerable<QuantidadeVeiculosViewModel> ObterQuantidadeVeiculos()
        {
            return _mapper.Map<IEnumerable<QuantidadeVeiculosViewModel>>(_perfilRepository.ObterQuantidadeVeiculos());
        }
        #endregion

        #region Sexo
        public IEnumerable<SexoViewModel> ObterSexos()
        {
            return _mapper.Map<IEnumerable<SexoViewModel>>(_perfilRepository.ObterSexos());
        }
        #endregion

        #region TempoHabilitação
        public IEnumerable<TempoHabilitacaoViewModel> ObterTempoHabilitacao()
        {
            return _mapper.Map<IEnumerable<TempoHabilitacaoViewModel>>(_perfilRepository.ObterTempoHabilitacao());
        }
        #endregion

        #region TipoResidencia
        public IEnumerable<TipoResidenciaViewModel> ObterTipoResidencia()
        {
            return _mapper.Map<IEnumerable<TipoResidenciaViewModel>>(_perfilRepository.ObterTipoResidencia());
        }
        #endregion

        public void Dispose()
        {
            _perfilRepository.Dispose();
        }
    }
}