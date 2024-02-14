namespace WebApplicationGym.Models.Gym
{
    public class ExerciseGym
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } 

        public int SeriesOfExercise { get; set; }

        public int Weight { get; set; } //obciążenie 

        public int Series {  get; set; }    

    }
}
