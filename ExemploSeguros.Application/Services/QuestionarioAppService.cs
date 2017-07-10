using System;
using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.QuestionarioRepo;

namespace ExemploSeguros.Application.Services
{
    public class QuestionarioAppService : IQuestionarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionarioRepository _questionarioRepository;

        public QuestionarioAppService(IMapper mapper, IQuestionarioRepository questionarioRepository)
        {
            _mapper = mapper;
            _questionarioRepository = questionarioRepository;
        }

        #region Questionario
        public QuestionarioViewModel ObterQuestionarioCotacao(Guid cotacaoId)
        {
            return _mapper.Map<QuestionarioViewModel>(_questionarioRepository.ObterQuestionarioCotacao(cotacaoId));
        }
        #endregion

        #region AntiFurto
        public IEnumerable<AntiFurtoViewModel> ObterAntiFurtos()
        {
            return _mapper.Map<IEnumerable<AntiFurtoViewModel>>(_questionarioRepository.ObterAntiFurtos());
        }
        #endregion

        #region GaragemFaculdade
        public IEnumerable<GararemFaculdadeViewModel> ObterGaragemFaculdades()
        {
            return _mapper.Map<IEnumerable<GararemFaculdadeViewModel>>(_questionarioRepository.ObterGaragemFaculdades());
        }
        #endregion

        #region GaragemTrabalho
        public IEnumerable<GararemTrabalhoViewModel> ObterGararemTrabalhos()
        {
            return _mapper.Map<IEnumerable<GararemTrabalhoViewModel>>(_questionarioRepository.ObterGararemTrabalhos());
        }
        #endregion

        #region GaragemResidencia
        public IEnumerable<GararemResidenciaViewModel> ObterGararemResidencias()
        {
            return _mapper.Map<IEnumerable<GararemResidenciaViewModel>>(_questionarioRepository.ObterGararemResidencias());
        }
        #endregion

        #region PropriedadeRastreador
        public IEnumerable<PropriedadeRastreadorViewModel> ObterPropriedadeRastreadors()
        {
            return _mapper.Map<IEnumerable<PropriedadeRastreadorViewModel>>(_questionarioRepository.ObterPropriedadeRastreadors());
        }
        #endregion

        #region Rastreador
        public IEnumerable<RastreadorViewModel> ObterRastreadores()
        {
            return _mapper.Map<IEnumerable<RastreadorViewModel>>(_questionarioRepository.ObterRastreadores());
        }
        #endregion

        #region RelacaoSegurado
        public IEnumerable<RelacaoSeguradoViewModel> ObterRelacaoSegurados()
        {
            return _mapper.Map<IEnumerable<RelacaoSeguradoViewModel>>(_questionarioRepository.ObterRelacaoSegurados());
        }
        #endregion

        public void Dispose()
        {
            _questionarioRepository.Dispose();
        }
    }
}