using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.ClienteRoot
{
    public class PaisResidencia
    {
        public int PaisResidenciaId { get; set; }

        public string Nome { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}