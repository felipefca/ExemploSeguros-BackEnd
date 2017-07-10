using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using ExemploSeguros.Domain.Validations.Documents;
using FluentValidation;
using FluentValidation.Results;

namespace ExemploSeguros.Domain.Validations
{
    public class QuestionarioEstaConsitenteValidation : AbstractValidator<Questionario>
    {
        public QuestionarioEstaConsitenteValidation()
        {
            ValidarQuestionarioSeguranca();
        }

        public void ValidarQuestionarioSeguranca()
        {
            Custom(
                item => !QuestionarioSegurancaValidation.Validar(item.FlagAntiFurto, QuestionarioSeguranca.AntiFurto,
                    item.AntiFurtoId, item.RastreadorId, item.PropriedadeRastreadorId)
                    ? new ValidationFailure("QuestionarioAntiFurto", ValidationMessages.AntiFurtoNaoSelecionado)
                    : null);

            Custom(
                item => !QuestionarioSegurancaValidation.Validar(item.FlagAntiFurto, QuestionarioSeguranca.Rastreador,
                    item.AntiFurtoId, item.RastreadorId, item.PropriedadeRastreadorId)
                    ? new ValidationFailure("QuestionarioRastreador", ValidationMessages.AntiFurtoNaoSelecionado)
                    : null);

            Custom(
                item => !QuestionarioSegurancaValidation.Validar(item.FlagAntiFurto, QuestionarioSeguranca.Propriedade,
                    item.AntiFurtoId, item.RastreadorId, item.PropriedadeRastreadorId)
                    ? new ValidationFailure("QuestionarioPropriedadeRastreador", ValidationMessages.PropRastNaoSelecionado)
                    : null);
        }
    }
}