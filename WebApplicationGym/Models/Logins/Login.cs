using System.ComponentModel.DataAnnotations;

namespace WebApplicationGym.Models.Logins
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        
    }
}
