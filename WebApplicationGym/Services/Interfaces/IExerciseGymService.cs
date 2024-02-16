using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Services.Interfaces
{
    public interface IExerciseGymService
    {
        Guid Save(ExerciseGym exercise);
    }
}
