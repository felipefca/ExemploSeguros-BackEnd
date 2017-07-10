using System;
using ExemploSeguros.Domain.Core.Interfaces;

namespace ExemploSeguros.Domain.Events.EventsHandlers
{
    public class CotacaoEventHandler : IHandler<CotacaoRegistradoEvent>,
        IHandler<CotacaoAtualizadoEvent>,
        IHandler<CotacaoRemoverEvent>
    {
        public void Handle(CotacaoAtualizadoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cotacao Atualizada com sucesso");
        }

        public void Handle(CotacaoRegistradoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cotacao Registrada com sucesso");
        }

        public void Handle(CotacaoRemoverEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cotacao Excluida com sucesso");
        }
    }
}