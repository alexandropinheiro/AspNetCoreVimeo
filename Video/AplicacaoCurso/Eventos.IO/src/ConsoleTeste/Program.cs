using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Core.Events;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Eventos;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new FakeBus();

            //Registro com sucesso
            var cmd = new RegistrarEventoCommand("Devx", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0, true, "Alexandro Pinheiro");



            Console.ReadKey();
        }

        public class FakeBus : IBus
        {
            public void RaiseEvent<T>(T theEvent) where T : Event
            {
                Publish(theEvent);
            }

            public void SendCommand<T>(T theCommand) where T : Command
            {
                Publish(theCommand);
            }

            private static void Publish<T>(T message) where T : Message
            {
                var msgType = message.MessageType;

                if (msgType.Equals("DomainNotification"))
                {
                    var obj = new DomainNotificationHandler();
                    ((IDomainNotificationHandler<T>)obj).Handle(message);
                }

                if (msgType.Equals("RegistrarEventoCommand") || 
                    msgType.Equals("AtualizarEventoCommand") || 
                    msgType.Equals("ExcluirEventoCommand"))
                {
                    var obj = new EventoCommandHandler(new FakeEventoRepository(), new FakeUow(), new FakeBus(), new DomainNotificationHandler());
                }
            }
        }
    }

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
