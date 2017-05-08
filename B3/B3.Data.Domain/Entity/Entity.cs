using System;
using System.Collections.Generic;
using B3.Data.Domain.Event;

namespace B3.Data.Domain.Entity
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }

        public IEnumerable<IEvent> Events
        {
            get { return events.Values; }
        }

        protected void AddEvent(IEvent domainEvent)
        {
            events[domainEvent.GetType()] = domainEvent;
        }

        protected void ClearEvents()
        {
            events.Clear();
        }

        private readonly IDictionary<Type, IEvent> events = new Dictionary<Type, IEvent>();
    }
}