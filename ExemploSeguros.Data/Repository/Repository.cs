using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace ExemploSeguros.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected ExemploSegurosContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository(ExemploSegurosContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}