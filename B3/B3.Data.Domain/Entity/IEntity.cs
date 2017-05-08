using System;
using System.Collections.Generic;
using B3.Data.Domain.Event;

namespace B3.Data.Domain.Entity
{
    public interface IEntity
    {
        Guid Id { get; set; }
        IEnumerable<IEvent> Events { get; } 
    }
}
