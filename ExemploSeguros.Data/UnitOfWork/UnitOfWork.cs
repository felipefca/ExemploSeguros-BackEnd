using ExemploSeguros.Data.Context;
using ExemploSeguros.Domain.Core.Commands;
using ExemploSeguros.Domain.Interfaces.Uow;

namespace ExemploSeguros.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExemploSegurosContext _context;

        public UnitOfWork(ExemploSegurosContext context)
        {
            _context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}