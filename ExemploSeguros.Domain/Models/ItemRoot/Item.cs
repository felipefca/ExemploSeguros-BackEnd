using System;
using System.Collections.Generic;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Models.CoberturasRoot;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Validations;

namespace ExemploSeguros.Domain.Models.ItemRoot
{
    public class Item : Entity<Item>
    {
        public Item(int produtoId, int modeloId, long? numChassi, bool flagRemarcado, string dataSaida, int? odometro, int usoId, int impostoId, Guid cotacaoId)
        {
            Id = Guid.NewGuid();
            ProdutoId = produtoId;
            ModeloId = modeloId;
            NumChassi = numChassi;
            FlagRemarcado = flagRemarcado;
            DataSaida = dataSaida;
            Odometro = odometro;
            UsoId = usoId;
            ImpostoId = impostoId;
            CotacaoId = cotacaoId;
        }

        protected Item() { }

        public int ProdutoId { get; private set; }

        public int ModeloId { get; private set; }

        public long? NumChassi { get; private set; }

        public bool FlagRemarcado { get; private set; }

        public string DataSaida { get; private set; }

        public int? Odometro { get; private set; }

        public int UsoId { get; private set; }

        public int ImpostoId { get; private set; }

        public Guid CotacaoId { get; private set; }

        public virtual Uso Uso { get; private set; }

        public virtual Imposto Imposto { get; private set; }

        public virtual Modelo Modelo { get; private set; }

        public virtual Produto Produto { get; private set; }

        public virtual Cotacao Cotacao { get; private set; }

        public ICollection<CoberturasItem> Coberturas { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new ItemEstaConsistenteValidation().Validate(this);

            ValidarCoberturas();

            return ValidationResult.IsValid;
        }

        private void ValidarCoberturas()
        {
            foreach (var cobertura in Coberturas)
            {
                if (cobertura.IsValid()) continue;

                foreach (var error in cobertura.ValidationResult.Errors)
                {
                    ValidationResult.Errors.Add(error);
                }
            }
        }

        #region Atribuições
        public void AtribuirCoberturas(CoberturasItem coberturas)
        {
            //if (!coberturas.IsValid()) return;
            Coberturas.Add(coberturas);
        }
        #endregion

        #region Factory
        public class ItemFactory
        {
            public Item NewItem(Guid id, int produtoId, int modeloId, long? numChassi, bool flagRemarcado, string dataSaida, int? odometro, 
                int usoId, int impostoId, Guid cotacaoId, List<CoberturasItem> coberturas)
            {
                var item = new Item
                {
                    Id = id,
                    ProdutoId = produtoId,
                    ModeloId = modeloId,
                    FlagRemarcado = flagRemarcado,
                    DataSaida = dataSaida,
                    UsoId = usoId,
                    ImpostoId = impostoId,
                    CotacaoId = cotacaoId
                };

                if (numChassi.HasValue)
                    item.NumChassi = numChassi.Value;

                if (odometro.HasValue)
                    item.Odometro = odometro.Value;

                if (coberturas != null)
                    item.Coberturas = coberturas;

                return item;
            }
        }
        #endregion
    }
}