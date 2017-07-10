using System;

namespace ExemploSeguros.Domain.Interfaces.User
{
    public interface IUser
    {
        string Name { get; }
        Guid GetUserId();
        bool IsAuthenticated();
    }
}