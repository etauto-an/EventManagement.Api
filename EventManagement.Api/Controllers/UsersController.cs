using EventManagement.Api.Models;
using EventManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.Api.Controllers
{
  [ApiController]
  [Microsoft.AspNetCore.Mvc.Route("api/users")]
  public class UsersController:ControllerBase
  {
    private readonly IUserService _userService;

    public UsersController( IUserService userService )
    {
      _userService = userService;
    }

    [HttpGet]
    public ActionResult <List<User>> GetUsers()
    {
      return Ok(_userService.GetUsers());
    }

    [HttpGet("{id:guid}")] 
    public ActionResult <User> GetUser(Guid id)
    {
      var _user = _userService.GetUser(id);
      if (_user == null)
      {
        return NotFound();
      }
      return Ok(_user);  
    }

    [HttpPost]
    public ActionResult<User> CreateUser(User input)
    {
      var newUser = _userService.CreateUser(input);
      return CreatedAtAction(nameof(GetUser), new {id = newUser.Id}, newUser);
    }
  }
}