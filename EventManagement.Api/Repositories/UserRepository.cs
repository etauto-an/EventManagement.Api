using EventManagement.Api.Data;
using EventManagement.Api.Models;

namespace EventManagement.Api.Repositories
{
  public class UserRepository : IUserRepository
  {
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
      _context = context;
    }
    public User Add(User input)
    {
        _context.Add(input);
        _context.SaveChanges();
        return input;
    }
    public List<User> GetAll()
    {
      return _context.Users.ToList();
    }

    public User? GetById(Guid id)
    {
      return _context.Users.Find(id);
    }
  }
}