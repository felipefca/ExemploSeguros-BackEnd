using System;
using ExemploSeguros.Application.ViewModels;

namespace ExemploSeguros.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel ObterClienteCotacao(Guid cotacaoId);

        EnderecoViewModel ObterEnderecoCliente(Guid clienteId);
    }
}