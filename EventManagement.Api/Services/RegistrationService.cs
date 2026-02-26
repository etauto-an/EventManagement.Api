using EventManagement.Api.Models;
using EventManagement.Api.Repositories;

namespace EventManagement.Api.Services
{
  public class RegistrationService : IRegistrationService
  {
    private readonly IRegistrationRepository _registrationRepository;

    public RegistrationService(IRegistrationRepository registrationRepository)
    {
      _registrationRepository = registrationRepository;
    }

    public Registration CreateRegistration(Registration input)
    {
      var newRegistration = new Registration
      {
        Id = Guid.NewGuid(),
        EventId = input.EventId,
        UserId = input.UserId,
        RegisteredAt = DateTime.UtcNow,
        Status = input.Status
      };

      return _registrationRepository.Add(newRegistration);
    }
  }
}
