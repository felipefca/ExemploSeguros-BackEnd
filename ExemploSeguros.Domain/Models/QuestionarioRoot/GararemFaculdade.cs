using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class GararemFaculdade
    {
        public int GaragemFaculdadeId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}