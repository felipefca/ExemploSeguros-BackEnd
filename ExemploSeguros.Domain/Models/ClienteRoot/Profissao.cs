using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.ClienteRoot
{
    public class Profissao
    {
        public int ProfissaoId { get; set; }

        public string Nome { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
    }
}