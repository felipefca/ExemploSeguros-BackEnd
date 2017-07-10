using ExemploSeguros.Domain.Core.Commands;
using ExemploSeguros.Domain.Core.Events;

namespace ExemploSeguros.Domain.Core.Interfaces
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;

        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}