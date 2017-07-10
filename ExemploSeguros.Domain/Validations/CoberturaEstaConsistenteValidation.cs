using ExemploSeguros.Domain.Models.CoberturasRoot;
using ExemploSeguros.Domain.Validations.Documents;
using FluentValidation;
using FluentValidation.Results;

namespace ExemploSeguros.Domain.Validations
{
    public class CoberturaEstaConsistenteValidation : AbstractValidator<CoberturasItem>
    {
        public CoberturaEstaConsistenteValidation()
        {
            ValidarCoberturasObrigatorias();
        }

        public void ValidarCoberturasObrigatorias()
        {
            Custom(item => !CoberturasValidation.Validar(item) ? new ValidationFailure("CoberturaObrigatoria", ValidationMessages.CoberturaObrigatoria) : null);
        }
    }
}