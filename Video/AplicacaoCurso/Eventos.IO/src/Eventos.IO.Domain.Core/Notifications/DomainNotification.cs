using Eventos.IO.Domain.Core.Events;
using System;

namespace Eventos.IO.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        public Guid NotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }

        public DomainNotification(string key, string value)
        {
            NotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
            Version = 1;
        }
    }
}
