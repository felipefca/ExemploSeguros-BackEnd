using System;
using ExemploSeguros.Domain.Core.Commands;

namespace ExemploSeguros.Domain.Commands.ClienteCommand
{
    public class IncluirClienteEventoCommand : Command
    {
        public IncluirClienteEventoCommand(Guid id, string nome, string sobrenome, string cpf, string telefone, string rg, string email, 
            DateTime dataNascimento, int profissaoId, int paisResidenciaId, IncluirEnderecoEventoCommand endereco, Guid cotacaoId)
        {
            Id = id;
            Nome = nome;
            SobreNome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
            Rg = rg;
            Email = email;
            DataNascimento = dataNascimento;
            ProfissaoId = profissaoId;
            PaisResidenciaId = paisResidenciaId;
            Endereco = endereco;
            CotacaoId = cotacaoId;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Cpf { get; private set; }
        public string Telefone { get; private set; }
        public string Rg { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int ProfissaoId { get; private set; }
        public int PaisResidenciaId { get; private set; }
        public IncluirEnderecoEventoCommand Endereco { get; private set; }
        public Guid CotacaoId { get; private set; }
    }
}