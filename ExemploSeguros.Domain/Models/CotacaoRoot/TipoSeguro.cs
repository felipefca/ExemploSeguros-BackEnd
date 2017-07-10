using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.CotacaoRoot
{
    public class TipoSeguro
    {
        public int TipoSeguroId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Cotacao> Cotacoes { get; set; }
    }
}