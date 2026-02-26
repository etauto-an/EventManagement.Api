using EventManagement.Api.Data;
using EventManagement.Api.Models;

namespace EventManagement.Api.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Event> GetAll()
        {
            return _context.Events.ToList();
        }

        public Event? GetById(Guid id)
        {
            return _context.Events.Find(id);
        }

        public Event Add(Event eventItem)
        {
            _context.Events.Add(eventItem);
            _context.SaveChanges();
            return eventItem;
        }
    }
}
