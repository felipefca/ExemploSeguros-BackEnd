using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.CotacaoRoot
{
    public class TipoCalculo
    {
        public int TipoCalculoId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Cotacao> Cotacoes { get; set; }
    }
}