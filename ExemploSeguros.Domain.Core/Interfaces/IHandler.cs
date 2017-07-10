using ExemploSeguros.Domain.Core.Events;

namespace ExemploSeguros.Domain.Core.Interfaces
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}