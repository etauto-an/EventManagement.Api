using EventManagement.Api.Models;
using EventManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.Api.Controllers
{
  [ApiController]
  [Microsoft.AspNetCore.Mvc.Route("api/events/{eventId:guid}/registrations")]
  public class RegistrationsController : ControllerBase
  {
    private readonly IRegistrationService _registrationService;
    private readonly IEventService _eventService;

    public RegistrationsController(IRegistrationService registrationService, IEventService eventService)
    {
      _registrationService = registrationService;
      _eventService = eventService;
    }

    [HttpPost]
    public ActionResult<Registration> CreateRegistration(Guid eventId, Registration input)
    {
        var existingEvent = _eventService.GetEvent(eventId);
        if (existingEvent is null)
        {
          return NotFound();
        }

        input.EventId = eventId;
        var newRegistration = _registrationService.CreateRegistration(input);
        return Created(string.Empty, newRegistration);
    }
  }
}
