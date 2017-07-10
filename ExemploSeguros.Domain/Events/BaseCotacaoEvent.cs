using System;
using ExemploSeguros.Domain.Core.Events;

namespace ExemploSeguros.Domain.Events
{
    public abstract class BaseCotacaoEvent : Event
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