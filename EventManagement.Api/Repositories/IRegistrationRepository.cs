using EventManagement.Api.Models;

namespace EventManagement.Api.Repositories
{
  public interface IRegistrationRepository
  {
    List<Registration> GetAll();
    Registration? GetById(Guid id);
    Registration Add(Registration input);
  }
}
