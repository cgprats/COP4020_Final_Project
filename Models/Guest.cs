using System.ComponentModel.DataAnnotations;

namespace COP4020_Final_Project.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter your arrival time")]
        public DateTime ArrivalTime { get; set; }
        [Required(ErrorMessage = "Please specify whether or not you require parking assistance")]
        public bool Parking { get; set; }
    }
}
