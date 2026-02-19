using EventManagement.Api.Models;

namespace EventManagement.Api.Repositories
{
  public class UserRepository : IUserRepository
  {
    private static List<User> _users = new List<User>
    {
        new User
        {
            Id = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            CreatedAt = new DateTime(2026, 1, 15, 10, 30, 0)
        },
        new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Alice",
            LastName = "Smith",
            Email = "alice.smith@example.com",
            CreatedAt = new DateTime(2026, 1, 20, 14, 45, 0)
        },
        new User
        {
            Id = Guid.NewGuid(),
            FirstName = "Michael",
            LastName = "Johnson",
            Email = "michael.johnson@example.com",
            CreatedAt = new DateTime(2026, 2, 1, 9, 15, 0)
        }
    };

    public User Add(User input)
    {
        _users.Add(input);
        return input;
    }
    public List<User> GetAll()
    {
      return _users;
    }

    public User? GetById(Guid id)
    {
      return _users.FirstOrDefault(s => s.Id == id);
    }
  }
}