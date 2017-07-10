using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class PerfilViewModel
    {
        public PerfilViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid CotacaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo CEP do Principal Condutor")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo {0} caracteres")]
        public string CpfPrincipalCondutor { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Nome do Principal Condutor")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomePrincipalCondutor { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato invalido")]
        public DateTime DataNascPrincipalCondutor { get; set; }

        [Required(ErrorMessage = "Preencha o Campo referente a se Reside menor de idade")]
        public bool FlagResideMenorIdade { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Segurado é o principal condutor")]
        public bool FlagSegPrincipalCondutor { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Segurado possui pontos na carteira")]
        public bool FlagPontosCarteira { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Estado Civil?")]
        public int EstadoCivilId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Tipo de Residência?")]
        public int TipoResidenciaId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Sexo")]
        public int SexoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Tempo de Habilitação?")]
        public int TempoHabilitacaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Qual a distância entre a residência do Principal Condutor até seu local de trabalho?")]
        public int DistanciaTrabalhoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Quantidade de veículos na Residência?")]
        public int QuantidadeVeiculoId { get; set; }
    }
}