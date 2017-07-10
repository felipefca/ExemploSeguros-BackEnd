using System;

namespace ExemploSeguros.Domain.Commands.CotacaoCommand
{
    public class RemoverCotacaoCommand : BaseCotacaoCommand
    {
        public RemoverCotacaoCommand(Guid id)
        {
            Id = id;
            AggregateId = Id;
        }
    }
}