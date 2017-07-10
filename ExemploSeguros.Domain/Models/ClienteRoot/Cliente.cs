using System;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Validations;
using ExemploSeguros.Domain.Models.CotacaoRoot;

namespace ExemploSeguros.Domain.Models.ClienteRoot
{
    public class Cliente : Entity<Cliente>
    {
        public Cliente(string nome, string sobreNome, string cpf, string telefone, string rg, string email, DateTime dataNascimento, int profissaoId, int paisResidenciaId, Guid cotacaoId)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            SobreNome = sobreNome;
            Cpf = cpf;
            Telefone = telefone;
            Rg = rg;
            Email = email;
            DataNascimento = dataNascimento;
            ProfissaoId = profissaoId;
            PaisResidenciaId = paisResidenciaId;
            CotacaoId = cotacaoId;
        }

        protected Cliente() { }

        public Guid CotacaoId { get; private set; }

        public string Nome { get; private set; }

        public string SobreNome { get; private set; }

        public string Cpf { get; private set; }

        public string Telefone { get; private set; }

        public string Rg { get; private set; }

        public string Email { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public int ProfissaoId { get; private set; }

        public int PaisResidenciaId { get; private set; }

        public virtual Profissao Profissao { get; private set; }

        public virtual PaisResidencia PaisResidencia { get; private set; }

        public virtual Endereco Endereco { get; private set; }

        public virtual Cotacao Cotacao { get; private set; }

        public override bool IsValid()
        {
            ValidationResult = new ClienteEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public void AtribuirPaises(PaisResidencia paises)
        {
            PaisResidencia = paises;
        }

        public void AtribuirProfissoes(Profissao profissao)
        {
            Profissao = profissao;
        }

        public void AtribuirEndereco(Endereco endereco)
        {
            if (!endereco.IsValid()) return;
            Endereco = endereco;
        }

        #region Factory

        public class ClienteFactory
        {
            public Cliente NewCliente(Guid id, string nome, string sobrenome, string cpf, string telefone,
                string rg, string email, DateTime dataNascimento, int profissaoId, int paisResidenciaId,
                Guid cotacaoId, Endereco endereco)
            {
                var cliente = new Cliente
                {
                    Id = id,
                    Nome = nome,
                    SobreNome = sobrenome,
                    Cpf = cpf,
                    Telefone = telefone,
                    Rg = rg,
                    Email = email,
                    DataNascimento = dataNascimento,
                    ProfissaoId = profissaoId,
                    PaisResidenciaId = paisResidenciaId,
                    CotacaoId = cotacaoId
                };

                endereco.ClienteId = id;
                cliente.Endereco = endereco;

                return cliente;
            }
        }

        #endregion
    }
}