using System.ComponentModel.DataAnnotations;

namespace EventManagement.Api.Models
{
  public class Registration
  {
    public Guid Id {get; set;}

    [Required]
    public Guid EventId {get; set;}

    [Required]
    public Guid UserId {get; set;}

    public DateTime RegisteredAt {get; set;}

    [Required]
    public string Status {get; set;} = string.Empty;
  }
}