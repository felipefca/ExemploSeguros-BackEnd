namespace ExemploSeguros.Domain.Validations.Documents
{
    public class ModeloValidation
    {
        public static bool Validar(int modeloId)
        {
            return modeloId != 0;
        }
    }
}