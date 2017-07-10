using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class ModeloViewModel
    {
        [Key]
        public int ModeloId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Descricao")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Ano de Fabricação")]
        [Required(ErrorMessage = "Preencha o Campo Ano de Fabricação")]
        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo {0} caracteres")]
        public string AnoFabricacao { get; set; }

        [Display(Name = "Ano do Modelo")]
        [Required(ErrorMessage = "Preencha o Campo Ano do Modelo")]
        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(4, ErrorMessage = "Mínimo {0} caracteres")]
        public string AnoModelo { get; set; }

        [Display(Name = "Zero KM?")]
        [Required(ErrorMessage = "Preencha o Campo FlagZeroKm")]
        public bool FlagZeroKm { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Valor")]
        [MaxLength(9, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Marca")]
        public int MarcaId { get; set; }

        public MarcaViewModel Marca { get; set; }
    }
}