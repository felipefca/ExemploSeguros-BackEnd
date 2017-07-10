using System;
using ExemploSeguros.Domain.Core.Commands;

namespace ExemploSeguros.Domain.Interfaces.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}