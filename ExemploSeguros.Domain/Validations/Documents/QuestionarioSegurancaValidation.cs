using ExemploSeguros.Domain.Core.Models;

namespace ExemploSeguros.Domain.Validations.Documents
{
    public class QuestionarioSegurancaValidation
    {
        public static bool Validar(bool flagAntiFurto, QuestionarioSeguranca option, int? antiFurtoId, int? rastreadorId, int? propriedadeRastreadorId)
        {
            if (!flagAntiFurto) return true;

            switch (option)
            {
                case QuestionarioSeguranca.AntiFurto:
                    if (antiFurtoId == null)
                        return false;
                    break;

                case QuestionarioSeguranca.Rastreador:
                    if (rastreadorId == null)
                        return false;
                    break;

                case QuestionarioSeguranca.Propriedade:
                    if (rastreadorId != null && propriedadeRastreadorId == null)
                        return false;
                    break;
            }

            return true; 
        }
    }
}