using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace WebApplicationGym.Models.Gym
{
    public class UserGym : IdentityUser
    {
        [Key]
        public Guid Id { get; set; }    
        public string Name { get; set; }

        public string? Surname { get; set; }

        public int PhoneNumber { get; set; } 

        public string Address { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string Password { get; set; }    
    }
}
