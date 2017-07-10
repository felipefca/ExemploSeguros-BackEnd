using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class QuestionarioViewModel
    {
        public QuestionarioViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid CotacaoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo CEP onde o veículo pernoita?")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string CepPernoite { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Veículo blindado?")]
        public bool FlagBlindado { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Veículo adaptado para deficiente físico?")]
        public bool FlagAdaptadoDeficiente { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Possui Kit Gás?")]
        public bool FlagKitGas { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Veículo alienado ou financiado?")]
        public bool FlagAlienado { get; set; }

        [Required(ErrorMessage = "Preencha o Campo O veículo segurado possui dispositivo anti-furto, rastreador, bloqueador ou localizador instalado e ativado?")]
        public bool FlagAntiFurto { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Existe garagem ou estacionamento fechado para o veículo?")]
        public bool FlagGararem { get; set; }

        public int? RastreadorId { get; set; }

        public int? AntiFurtoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Relação do Segurado com o Proprietário Legal do Veículo?")]
        public int RelacaoSeguradoId { get; set; }

        public int? GararemResidenciaId { get; set; }

        public int? GararemTrabalhoId { get; set; }

        public int? GaragemFaculdadeId { get; set; }

        public int? PropriedadeRastreadorId { get; set; }

        public AntiFurtoViewModel AntiFurto { get; set; }

        public RastreadorViewModel Rastreador { get; set; }

        public RelacaoSeguradoViewModel RelacaoSegurado { get; set; }

        public GararemResidenciaViewModel GararemResidencia { get; set; }

        public GararemTrabalhoViewModel GararemTrabalho { get; set; }

        public GararemFaculdadeViewModel GararemFaculdade { get; set; }

        public PropriedadeRastreadorViewModel PropriedadeRastreador { get; set; }
    }
}