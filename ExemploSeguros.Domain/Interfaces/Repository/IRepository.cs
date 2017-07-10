using ExemploSeguros.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExemploSeguros.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
        void Adicionar(TEntity obj);

        TEntity ObterPorId(Guid id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity obj);

        void Remover(Guid id);

        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

        int SaveChanges();
    }
}
