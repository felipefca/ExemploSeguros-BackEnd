using ExemploSeguros.Domain.Models.PerfilRoot;
using FluentValidation;

namespace ExemploSeguros.Domain.Validations
{
    public class PerfilEstaConsistenteValidation : AbstractValidator<Perfil>
    {
        public PerfilEstaConsistenteValidation()
        {
            
        }
    }
}