using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class PropriedadeRastreador
    {
        public int PropriedadeRastreadorId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}