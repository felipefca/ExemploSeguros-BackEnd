using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class RelacaoSegurado
    {
        public int RelacaoSeguradoId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}