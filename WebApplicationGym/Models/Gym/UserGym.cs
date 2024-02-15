namespace WebApplicationGym.Models.Gym
{
    public class UserGym
    {
        public Guid Id { get; set; }    
        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public int PhoneNumber { get; set; } 

        public string Address { get; set; }

        public string Email { get; set; } 
    }
}
