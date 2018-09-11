using Eventos.IO.Domain.Core.Bus;
using Eventos.IO.Domain.Core.Commands;
using Eventos.IO.Domain.Core.Events;
using System;

namespace Eventos.IO.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IBus
    {
        public static Func<IServiceProvider> ContainerAccessor { get; set; }

        public void RaiseEvent<T>(T theEvent) where T : Event
        {
            
        }

        public void SendCommand<T>(T theCommand) where T : Command
        {
            
        }

        private static void Publish<T>(T message) where T : Message
        {

        }
    }
}
