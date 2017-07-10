using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo;

namespace ExemploSeguros.Application.Services
{
    public class TipoSeguroAppService : ITipoSeguroAppService
    {
        private readonly IMapper _mapper;
        private readonly ICotacaoRepository _cotacaoRepository;

        public TipoSeguroAppService(IMapper mapper, ICotacaoRepository cotacaoRepository)
        {
            _mapper = mapper;
            _cotacaoRepository = cotacaoRepository;
        }

        public IEnumerable<TipoSeguroViewModel> ObterTiposSeguro()
        {
            return _mapper.Map<IEnumerable<TipoSeguroViewModel>>(_cotacaoRepository.ObterTiposSeguro());
        }

        public void Dispose()
        {
            _cotacaoRepository.Dispose();
        }
    }
}