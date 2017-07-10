using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class UsoViewModel
    {
        [Key]
        public int UsoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Descricao")]
        [MaxLength(80, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }
    }
}