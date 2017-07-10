using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.PerfilRoot
{
    public class QuantidadeVeiculos
    {
        public int QuantidadeVeiculoId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Perfil> Perfis { get; set; }
    }
}