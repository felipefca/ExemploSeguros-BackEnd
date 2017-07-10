using ExemploSeguros.Domain.Core.Commands;
using System;

namespace ExemploSeguros.Domain.Commands.ClienteCommand
{
    public class IncluirEnderecoEventoCommand : Command
    {
        public IncluirEnderecoEventoCommand(Guid id, string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado, Guid clienteId)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            ClienteId = clienteId;
        }

        public Guid Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid ClienteId { get; private set; }
    }
}