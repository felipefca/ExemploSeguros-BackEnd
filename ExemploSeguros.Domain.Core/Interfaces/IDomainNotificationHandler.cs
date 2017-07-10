using System.Collections.Generic;
using ExemploSeguros.Domain.Core.Events;

namespace ExemploSeguros.Domain.Core.Interfaces
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotification();
        List<T> GetNotification();
    }
}