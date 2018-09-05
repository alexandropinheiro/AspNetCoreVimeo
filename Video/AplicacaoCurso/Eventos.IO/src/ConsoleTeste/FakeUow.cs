using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Interfaces;
using System;

namespace ConsoleTeste
{
    public class FakeUow : IUnitOfWorks
    {
        public CommandResponse Commit()
        {
            return new CommandResponse(true);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
