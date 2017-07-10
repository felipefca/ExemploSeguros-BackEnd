using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class AntiFurto
    {
        public int AntiFurtoId { get; set; }

        public string Nome { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}