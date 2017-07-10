using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ClienteRepo;

namespace ExemploSeguros.Application.Services
{
    public class PaisResidenciaAppService : IPaisResidenciaAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public PaisResidenciaAppService(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<PaisResidenciaViewModel> ObterTodosPaises()
        {
            return _mapper.Map<IEnumerable<PaisResidenciaViewModel>>(_clienteRepository.ObterPaises());
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}