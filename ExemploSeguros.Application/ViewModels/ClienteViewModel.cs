using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            Id = Guid.NewGuid();
            Endereco = new EnderecoViewModel();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid CotacaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo SobreNome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-Mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o Campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Telefone")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o Campo RG")]
        [MaxLength(7, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(7, ErrorMessage = "Mínimo {0} caracteres")]
        public string Rg { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato invalido")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Profissao")]
        public int ProfissaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Pais de Residência")]
        public int PaisResidenciaId { get; set; }

        public ProfissaoViewModel Profissao { get; set; }

        public PaisResidenciaViewModel PaisResidencia { get; set; }

        public EnderecoViewModel Endereco { get; set; }
    }
}