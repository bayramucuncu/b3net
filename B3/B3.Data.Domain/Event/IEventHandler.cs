using System.Threading.Tasks;

namespace B3.Data.Domain.Event
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent domainEvent);
    }
}