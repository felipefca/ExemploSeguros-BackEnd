using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class RastreadorViewModel
    {
        [Key]
        public int RastreadorId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
    }
}