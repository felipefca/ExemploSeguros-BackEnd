using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel()
        {
            Id = Guid.NewGuid();
            ListCoberturasItem = new List<CoberturaItemViewModel>();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid CotacaoId { get; set; }

        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Selecione um Veículo válido")]
        public int ModeloId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Uso")]
        public int UsoId { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Isenção de Imposto")]
        public int ImpostoId { get; set; }

        public string DataSaida { get; set; }

        public int? Odometro { get; set; }

        public long? NumChassi { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Chassi Remarcado?")]
        public bool FlagRemarcado { get; set; }

        public UsoViewModel Uso { get; set; }

        public ImpostoViewModel Imposto { get; set; }

        public ModeloViewModel Modelo { get; set; }

        public ProdutoViewModel Produto { get; set; }

        public List<CoberturaItemViewModel> ListCoberturasItem { get; set; }
    }
}