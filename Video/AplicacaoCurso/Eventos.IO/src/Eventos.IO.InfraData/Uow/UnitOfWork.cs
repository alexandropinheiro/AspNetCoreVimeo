using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Interfaces;
using Eventos.IO.InfraData.Context;

namespace Eventos.IO.InfraData.Uow
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly EventosContext _context;

        public UnitOfWork(EventosContext context)
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
