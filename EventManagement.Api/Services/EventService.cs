using EventManagement.Api.Models;
using EventManagement.Api.Repositories;

namespace EventManagement.Api.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public List<Event> GetEvents()
        {
            return _eventRepository.GetAll();
        }

        public Event? GetEvent(Guid id)
        {
            return _eventRepository.GetById(id);
        }

        public Event CreateEvent(Event input)
        {
            var newEvent = new Event
            {
                Id = Guid.NewGuid(),
                Title = input.Title,
                Description = input.Description,
                StartDateTime = input.StartDateTime,
                EndDateTime = input.EndDateTime,
                Location = input.Location,
                Capacity = input.Capacity,
            };
            return _eventRepository.Add(newEvent);
        }
    }
}