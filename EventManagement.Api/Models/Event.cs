using System.ComponentModel.DataAnnotations;

namespace EventManagement.Api.Models
{
    public class Event
    {
        public Guid Id {get; set;}

        // For non-nullable warnings
        [Required]
        public string Title {get; set;} = string.Empty;

        [Required]
        public string Description {get;set;} = string.Empty;

        public DateTime StartDateTime {get;set;}

        public DateTime EndDateTime {get;set;}

        [Required]
        public string Location {get;set;} = string.Empty;

        public int Capacity {get;set;}

        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();


    }
}