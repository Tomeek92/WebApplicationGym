using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Services.Interfaces
{
    public interface IExerciseGymService
    {
        public int Save(ExerciseGym exercise);
        List<ExerciseGym> GetAll();
        ExerciseGym Get(Guid Id);
        Guid Delete(Guid Id);
    }
}
