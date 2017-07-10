using System.Collections.Generic;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class GararemResidencia
    {
        public int GaragemResidenciaId { get; set; }

        public string Descricao { get; set; }

        public ICollection<Questionario> Questionarios { get; set; }
    }
}