using ExemploSeguros.Domain.Models.CotacaoRoot;
using FluentValidation;
using System;

namespace ExemploSeguros.Domain.Validations
{
    public class CotacaoEstaConsistenteValidation : AbstractValidator<Cotacao>
    {
        public CotacaoEstaConsistenteValidation()
        {
            ValidarDataInicial();
        }

        public void ValidarDataInicial()
        {
            RuleFor(c => c.DataVigenciaInicial)
                .LessThan(c => c.DataVigenciaFinal)
                .WithMessage(ValidationMessages.DataInicialMaiorqueFinal);

            RuleFor(c => c.DataVigenciaInicial)
                .GreaterThan(DateTime.Now)
                .WithMessage(ValidationMessages.DataInicialInvalida);
        }
    }
}