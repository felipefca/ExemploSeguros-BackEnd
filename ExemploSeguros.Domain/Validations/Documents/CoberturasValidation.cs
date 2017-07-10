using ExemploSeguros.Domain.Models.CoberturasRoot;

namespace ExemploSeguros.Domain.Validations.Documents
{
    public class CoberturasValidation
    {
        public static bool Validar(CoberturasItem coberturas)
        {
            return coberturas != null;
        }
    }
}