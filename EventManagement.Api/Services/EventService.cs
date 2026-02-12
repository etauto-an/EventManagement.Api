using EventManagement.Api.Models;

namespace EventManagement.Api.Services
{
    public class EventService : IEventService
    {
        private static List<Event> Events = new List<Event>
        {
            new Event { Id = Guid.NewGuid(),
            Title = "Tech Conference 2026",
            Description = "A conference about modern software development.",
            StartDateTime = new DateTime(2026, 3, 10, 9, 0, 0),
            EndDateTime = new DateTime(2026, 3, 10, 17, 0, 0),
            Location = "Seattle, WA",
            Capacity = 250
            },
        };

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
            Events.Add(newEvent);

            return newEvent;
        }

        public Event? GetEvent(Guid id)
        {
            return Events.FirstOrDefault(s => s.Id == id);
        }
        public List<Event> GetEvents()
        {
            return Events;
        }
    }
}