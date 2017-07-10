using System;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Validations;

namespace ExemploSeguros.Domain.Models.CoberturasRoot
{
    public class CoberturasItem : Entity<CoberturasItem>
    {
        public CoberturasItem(Guid itemId, int coberturaId, double valor)
        {
            Id = Guid.NewGuid();
            ItemId = itemId;
            CoberturaId = coberturaId;
            Valor = valor;
        }

        protected CoberturasItem() { }

        public Guid ItemId { get; private set; }

        public int CoberturaId { get; private set; }

        public double Valor { get; private set; }

        public virtual Item Item { get; private set; }

        public virtual Coberturas Coberturas { get; private set; }

        public override bool IsValid()
        {
            ValidationResult = new CoberturaEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public void AtribuirCoberturas(Coberturas cobertura)
        {
            Coberturas = cobertura;
        }

        public void AtribuirItem(Item item)
        {
            Item = item;
        }

        #region Factory

        public class CoberturasItemFactory
        {
            public CoberturasItem NewCoberturasItem(Guid id, Guid itemId, int coberturaId, double valor)
            {
                var coberturasItem = new CoberturasItem
                {
                    Id = id,
                    ItemId = itemId,
                    CoberturaId = coberturaId,
                    Valor = valor
                };

                return coberturasItem;
            }
        }
        #endregion
    }
}