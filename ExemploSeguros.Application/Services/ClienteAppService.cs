using System;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ClienteRepo;

namespace ExemploSeguros.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ClienteAppService(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public ClienteViewModel ObterClienteCotacao(Guid cotacaoId)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.ObterClienteCotacao(cotacaoId));
        }

        public EnderecoViewModel ObterEnderecoCliente(Guid clienteId)
        {
            return _mapper.Map<EnderecoViewModel>(_clienteRepository.ObterEnderecoCliente(clienteId));
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}