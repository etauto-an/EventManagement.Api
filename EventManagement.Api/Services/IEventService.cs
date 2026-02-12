using EventManagement.Api.Models;

namespace EventManagement.Api.Services
{
    
public interface IEventService
    {
        List<Event> GetEvents();
        Event? GetEvent( Guid id );
        Event CreateEvent( Event input );

    }
}