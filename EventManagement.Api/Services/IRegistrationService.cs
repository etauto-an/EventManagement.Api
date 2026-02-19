using EventManagement.Api.Models;

namespace EventManagement.Api.Services
{
  public interface IRegistrationService
  {
    Registration CreateRegistration(Registration input);
  }
}