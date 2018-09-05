using Eventos.IO.Domain.Eventos;
using Eventos.IO.Domain.Eventos.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConsoleTeste
{
    public class FakeEventoRepository : IEventoRepository
    {        
        public void Add(Evento obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> Find(Expression<Func<Evento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> GetAll()
        {
            throw new NotImplementedException();
        }

        public Evento GetById(Guid Id)
        {
            return new Evento("Fake", DateTime.Now, DateTime.Now, true, 0, true, "Empresa");
        }

        public void Remove(Guid Id)
        {
            //throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Evento obj)
        {
            //return new Evento("Fake", DateTime.Now, DateTime.Now, true, 0, true, "Empresa");
        }
    }
}
