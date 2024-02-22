using System.ComponentModel.DataAnnotations;

namespace WebApplicationGym.Models.Register
{
    public class Register
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email {  get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }

        public string Surname { get; set; }
    }
}
