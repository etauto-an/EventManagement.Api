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

    public RegistrationsController( IRegistrationService registrationService)
    {
      _registrationService = registrationService;
    }

    [HttpPost]
    public ActionResult<Registration> CreateRegistration(Guid eventId, Registration input)
    {
        var newRegistration = _registrationService.CreateRegistration(input);
        return Created(string.Empty, newRegistration);
    }
  }
}