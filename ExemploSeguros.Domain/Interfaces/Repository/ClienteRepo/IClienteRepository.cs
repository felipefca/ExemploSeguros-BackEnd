using ExemploSeguros.Domain.Models.ClienteRoot;
using System;
using System.Collections.Generic;

namespace ExemploSeguros.Domain.Interfaces.Repository.ClienteRepo
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        #region Cliente

        Cliente ObterClienteCotacao(Guid cotacaoId);

        #endregion

        #region Endereco

        Endereco ObterEnderecoCliente(Guid clienteId);

        #endregion

        #region Pais de Residencia

        IEnumerable<PaisResidencia> ObterPaises();

        #endregion

        #region Profissao

        IEnumerable<Profissao> ObterProfissoes();

        #endregion
    }
}
