using EventManagement.Api.Models;

namespace EventManagement.Api.Services
{
  public class UserService : IUserService
  {

    private static List<User> Users = new List<User>
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
    public User CreateUser(User input)
    {
      var newUser = new User
      {
        Id = Guid.NewGuid(),
        FirstName = input.FirstName,
        LastName = input.LastName,
        Email = input.Email,
        CreatedAt = input.CreatedAt,
      };
      Users.Add(newUser);

      return newUser;
    }

    public User? GetUser(Guid id)
    {
      return Users.FirstOrDefault(s => s.Id == id);
    }

    public List<User> GetUsers()
    {
      return Users;
    }
  }
}