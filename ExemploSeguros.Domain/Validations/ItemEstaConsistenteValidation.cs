using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Validations.Documents;
using FluentValidation;
using FluentValidation.Results;

namespace ExemploSeguros.Domain.Validations
{
    public class ItemEstaConsistenteValidation : AbstractValidator<Item>
    {
        public ItemEstaConsistenteValidation()
        {
            ValidarModeloSelecionado();
        }

        public void ValidarModeloSelecionado()
        {
            Custom(item => !ModeloValidation.Validar(item.ModeloId) ? new ValidationFailure("Modelo", ValidationMessages.ModeloInvalido) : null);
        }
    }
}