using EventManagement.Api.Models;

namespace EventManagement.Api.Repositories
{
  public class RegistrationRepository : IRegistrationRepository
  {
    private static List<Registration> _registrations = new List<Registration>
    {
      new Registration
      {
        Id = Guid.NewGuid(),
        EventId = Guid.NewGuid(),
        UserId = Guid.NewGuid(),
        RegisteredAt = new DateTime(2026, 2, 1, 10, 0, 0),
        Status = "Confirmed"
      },
      new Registration
      {
        Id = Guid.NewGuid(),
        EventId = Guid.NewGuid(),
        UserId = Guid.NewGuid(),
        RegisteredAt = new DateTime(2026, 2, 5, 14, 30, 0),
        Status = "Confirmed"
      },
      new Registration
      {
        Id = Guid.NewGuid(),
        EventId = Guid.NewGuid(),
        UserId = Guid.NewGuid(),
        RegisteredAt = new DateTime(2026, 2, 10, 9, 0, 0),
        Status = "Cancelled"
      }
    };

    public Registration Add(Registration input)
    {
      _registrations.Add(input);
      return input;
    }

    public List<Registration> GetAll()
    {
      return _registrations;
    }

    public Registration? GetById(Guid id)
    {
      return _registrations.FirstOrDefault(r => r.Id == id);
    }
  }
}
