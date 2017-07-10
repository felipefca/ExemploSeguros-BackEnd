using System;

namespace ExemploSeguros.Domain.Events
{
    public class CotacaoRemoverEvent : BaseCotacaoEvent
    {
        public CotacaoRemoverEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}