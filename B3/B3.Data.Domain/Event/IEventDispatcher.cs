using System.Threading.Tasks;

namespace B3.Data.Domain.Event
{
    public interface IEventDispatcher
    {
        Task DispatchAsync<TEvent>(params TEvent[] events) where TEvent : IEvent;
    }
}