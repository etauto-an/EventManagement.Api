using EventManagement.Api.Models;

namespace EventManagement.Api.Services
{
  public class RegistrationService : IRegistrationService
  {
    private static List<Registration> Registrations = new List<Registration>
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
        Registrations.Add(newRegistration);
        return newRegistration;
    }
  }
}