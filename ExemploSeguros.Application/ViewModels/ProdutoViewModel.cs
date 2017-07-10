using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Descricao")]
        [MaxLength(100, ErrorMessage = "Máximo {0} Descricao")]
        [MinLength(2, ErrorMessage = "Mínimo {0} Descricao")]
        public string Descricao { get; set; }
    }
}