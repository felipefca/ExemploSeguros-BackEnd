using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class Rastreador
    {
        public int RastreadorId { get; set; }

        public string Nome { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}