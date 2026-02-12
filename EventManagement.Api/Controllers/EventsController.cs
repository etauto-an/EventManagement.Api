using EventManagement.Api.Models;
using EventManagement.Api.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.Api.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/events")]
    public class EventsController:ControllerBase
    {

        private readonly IEventService _eventService;

        public EventsController()
        {
            _eventService = new EventService();
        }

        [HttpGet]
        public ActionResult <List<Event>> GetEvents()
        {
            return Ok(_eventService.GetEvents());
        }

        [HttpGet("id:guid")]
        public ActionResult <Event> GetEvent(Guid id)
        {            
            var _event = _eventService.GetEvent(id);
            if (_event == null)
            {
                return NotFound();
            }
            return Ok(_event);
        }

        [HttpPost]
        public ActionResult<Event> CreateEvent(Event input)
        {
            var newEvent = _eventService.CreateEvent(input);
            return CreatedAtAction(nameof(GetEvent), new {id = newEvent.Id}, newEvent);
        }

    }
}