using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class CotacaoViewModel
    {
        public CotacaoViewModel()
        {
            Id = Guid.NewGuid();
            Cliente = new ClienteViewModel();
            Item = new ItemViewModel();
            Questionario= new QuestionarioViewModel();
            Perfil = new PerfilViewModel();
        }

        #region Cotação
        [Key]
        public Guid Id { get; set; }

        public int NumCotacao { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Tipo de Cálculo")]
        public int TipoCalculoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Tipo de Seguro")]
        public int TipoSeguroId { get; set; }

        public decimal PremioTotal { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataCalculo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato invalido")]
        public DateTime DataVigenciaInicial { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato invalido")]
        public DateTime DataVigenciaFinal { get; set; }

        public TipoCalculoViewModel TiposCalculo { get; set; }

        public TipoSeguroViewModel TiposSeguro { get; set; }

        public Guid UserId { get; set; }

        public ClienteViewModel Cliente { get; set; }

        public ItemViewModel Item { get; set; }

        public QuestionarioViewModel Questionario { get; set; }

        public PerfilViewModel Perfil { get; set; }
        #endregion
    }
}