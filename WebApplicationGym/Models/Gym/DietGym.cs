namespace WebApplicationGym.Models.Gym
{
    public class DietGym
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public int Calories { get; set; } 
        public string? ProductToEat { get; set; }

    }
}
