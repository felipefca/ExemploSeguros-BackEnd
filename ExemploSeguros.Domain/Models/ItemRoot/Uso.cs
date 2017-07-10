using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.ItemRoot
{
    public class Uso
    {
        public int UsoId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Item> Itens { get; set; }
    }
}