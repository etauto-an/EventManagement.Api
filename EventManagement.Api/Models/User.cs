using System.ComponentModel.DataAnnotations;

namespace EventManagement.Api.Models
{
  public class User
  {
    public Guid Id {get; set;}

    [Required]
    public string FirstName {get; set;}  = string.Empty;

    [Required]
    public string LastName {get; set;}  = string.Empty;
    
    [Required]
    public string Email {get; set;}  = string.Empty;

    public DateTime CreatedAt {get; set;}


  }
}