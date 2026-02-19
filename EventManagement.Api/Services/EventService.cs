using EventManagement.Api.Models;

namespace EventManagement.Api.Services
{
    public class EventService : IEventService
    {
        // Sample data
       private static List<Event> Events = new List<Event>
        {
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "Tech Conference 2026",
                Description = "A conference about modern software development.",
                StartDateTime = new DateTime(2026, 3, 10, 9, 0, 0),
                EndDateTime = new DateTime(2026, 3, 10, 17, 0, 0),
                Location = "Seattle, WA",
                Capacity = 250
            },
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "Startup Networking Summit",
                Description = "An event for entrepreneurs and investors to connect.",
                StartDateTime = new DateTime(2026, 4, 5, 13, 0, 0),
                EndDateTime = new DateTime(2026, 4, 5, 18, 0, 0),
                Location = "San Francisco, CA",
                Capacity = 150
            },
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "Cybersecurity Workshop",
                Description = "Hands-on training covering modern security practices.",
                StartDateTime = new DateTime(2026, 5, 20, 10, 0, 0),
                EndDateTime = new DateTime(2026, 5, 20, 16, 0, 0),
                Location = "Austin, TX",
                Capacity = 100
            }
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