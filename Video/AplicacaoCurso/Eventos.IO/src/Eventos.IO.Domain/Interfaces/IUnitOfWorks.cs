using Eventos.IO.Domain.Core.Commands;
using System;

namespace Eventos.IO.Domain.Interfaces
{
    public interface IUnitOfWorks : IDisposable
    {
        CommandResponse Commit();
    }
}
