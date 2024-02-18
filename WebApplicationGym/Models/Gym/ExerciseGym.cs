using System.ComponentModel.DataAnnotations;

namespace WebApplicationGym.Models.Gym
{
    public class ExerciseGym
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; } = null!;
        public string Description { get; set; }

        public int SeriesOfExercise { get; set; } 

        public int Weight { get; set; } //obciążenie 

          

    }
}
