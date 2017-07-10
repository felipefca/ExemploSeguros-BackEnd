using ExemploSeguros.Domain.Models.ClienteRoot;
using FluentValidation;

namespace ExemploSeguros.Domain.Validations
{
    public class EnderecoEstaConsistenteValidation : AbstractValidator<Endereco>
    {
        public EnderecoEstaConsistenteValidation()
        {

        }
    }
}