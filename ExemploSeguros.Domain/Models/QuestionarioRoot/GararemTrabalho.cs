using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class GararemTrabalho
    {
        public int GaragemTrabalhoId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}