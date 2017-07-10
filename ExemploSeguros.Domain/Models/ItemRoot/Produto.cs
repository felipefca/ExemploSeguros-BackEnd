using System.Collections.Generic;
using ExemploSeguros.Domain.Models.CoberturasRoot;

namespace ExemploSeguros.Domain.Models.ItemRoot
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Descricao { get; set; }

        public ICollection<CoberturasProduto> CoberturasProduto { get; set; }
    }
}