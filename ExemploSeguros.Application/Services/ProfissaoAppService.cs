using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ClienteRepo;

namespace ExemploSeguros.Application.Services
{
    public class ProfissaoAppService : IProfissaoAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ProfissaoAppService(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<ProfissaoViewModel> ObterTodasProfissoes()
        {
            return _mapper.Map<IEnumerable<ProfissaoViewModel>>(_clienteRepository.ObterProfissoes());
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}