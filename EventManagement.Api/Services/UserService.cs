using EventManagement.Api.Models;
using EventManagement.Api.Repositories;

namespace EventManagement.Api.Services
{
  public class UserService : IUserService
  {

    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }
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

      return _userRepository.Add(newUser);
    }

    public User? GetUser(Guid id)
    {
      return _userRepository.GetById(id);
    }

    public List<User> GetUsers()
    {
      return _userRepository.GetAll();
    }
  }
}