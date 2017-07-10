using System;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Validations;

namespace ExemploSeguros.Domain.Models.ClienteRoot
{
    public class Endereco : Entity<Endereco>
    {
        public Endereco(string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado)
        {
            Id = Guid.NewGuid();
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        protected Endereco() { }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public Guid ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new EnderecoEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}