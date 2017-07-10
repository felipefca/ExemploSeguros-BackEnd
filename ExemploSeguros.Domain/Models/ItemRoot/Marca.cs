using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.ItemRoot
{
    public class Marca
    {
        public int MarcaId { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }

        public ICollection<Modelo> Modelos { get; set; }
    }
}