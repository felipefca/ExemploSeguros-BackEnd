using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploSeguros.Application.ViewModels
{
    public class CoberturaItemViewModel
    {
        public CoberturaItemViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public Guid ItemId { get; set; }

        public int CoberturaId { get; set; }

        public float Valor { get; set; }

        public virtual CoberturasViewModel Coberturas { get; set; }
    }
}