using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo;

namespace ExemploSeguros.Application.Services
{
    public class TipoCalculoAppService : ITipoCalculoAppService
    {
        private readonly IMapper _mapper;
        private readonly ICotacaoRepository _cotacaoRepository;

        public TipoCalculoAppService(IMapper mapper, ICotacaoRepository cotacaoRepository)
        {
            _mapper = mapper;
            _cotacaoRepository = cotacaoRepository;
        }

        public TipoCalculoViewModel ObterTipoCalculoPorId(int tipoCalculoId)
        {
            return _mapper.Map<TipoCalculoViewModel>(_cotacaoRepository.ObterTipoCalculoPorId(tipoCalculoId));
        }

        public IEnumerable<TipoCalculoViewModel> ObterTiposCalculo()
        {
            return _mapper.Map<IEnumerable<TipoCalculoViewModel>>(_cotacaoRepository.ObterTiposCalculo());
        }

        public void Dispose()
        {
            _cotacaoRepository.Dispose();
        }
    }
}