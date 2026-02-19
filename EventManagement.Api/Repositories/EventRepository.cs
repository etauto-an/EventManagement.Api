using EventManagement.Api.Models;

namespace EventManagement.Api.Repositories
{
    public class EventRepository : IEventRepository
    {
       private static List<Event> _events = new List<Event>
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

        public List<Event> GetAll()
        {
            return _events;
        }

        public Event? GetById(Guid id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }

        public Event Add(Event input)
        {
            _events.Add(input);
            return input;
        }
    }
}