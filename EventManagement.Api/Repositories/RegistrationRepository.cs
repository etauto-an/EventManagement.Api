using EventManagement.Api.Data;
using EventManagement.Api.Models;
namespace EventManagement.Api.Repositories
{
  public class RegistrationRepository : IRegistrationRepository
  {
    private readonly ApplicationDbContext _context;

    public RegistrationRepository(ApplicationDbContext context)
    {
      _context = context;
    }
    public Registration Add(Registration input)
    {
      _context.Registrations.Add(input);
      _context.SaveChanges();
      return input;
    }

    public List<Registration> GetAll()
    {
      return _context.Registrations.ToList();
    }

    public Registration? GetById(Guid id)
    {
      return _context.Registrations.Find(id);
    }
  }
}
