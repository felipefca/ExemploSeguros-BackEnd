using System;
using ExemploSeguros.Domain.Models.ClienteRoot;
using ExemploSeguros.Domain.Validations.Documents;
using FluentValidation;
using FluentValidation.Results;

namespace ExemploSeguros.Domain.Validations
{
    public class ClienteEstaConsistenteValidation : AbstractValidator<Cliente>
    {
        public ClienteEstaConsistenteValidation()
        {
            ValidarCpf();
            ValidarEmail();
            ValidarMaioridade();
        }

        public void ValidarCpf()
        {
            Custom(cliente => !CpfValidation.Validar(cliente.Cpf) ? new ValidationFailure("CPF", ValidationMessages.CpfInvalido) : null);
        }

        public void ValidarEmail()
        {
            Custom(cliente => !EmailValidation.Validate(cliente.Email) ? new ValidationFailure("Email", ValidationMessages.EmailInvalido) : null );
        }

        public void ValidarMaioridade()
        {
            Custom(cliente =>
            {
                var data = (DateTime.Now.Year - cliente.DataNascimento.Year).ToString();

                return int.Parse(data) < 18
                    ? new ValidationFailure("Data de Nascimento", ValidationMessages.ClienteMaioridadeInvalido)
                    : null;
            });
        }
    }
}