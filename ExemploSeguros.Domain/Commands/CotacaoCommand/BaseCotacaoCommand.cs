using System;
using ExemploSeguros.Domain.Core.Commands;

namespace ExemploSeguros.Domain.Commands.CotacaoCommand
{
    public abstract class BaseCotacaoCommand : Command
    {
        public Guid Id { get; protected set; }

        public int NumCotacao { get; protected set; }

        public DateTime DataCalculo { get; protected set; }

        public DateTime DataCadastro { get; protected set; }

        public DateTime DataVigenciaInicial { get; protected set; }

        public DateTime DataVigenciaFinal { get; protected set; }

        public Guid UserId { get; protected set; }

        public decimal PremioTotal { get; protected set; }

        public int TipoCalculoId { get; protected set; }

        public int TipoSeguroId { get; protected set; }
    }
}
