using WebApplicationGym.Models.Gym;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Services
{
    public class ExerciseGymServices : IExerciseGymService
    {
        private readonly WebApplicationGymDbContext _exerciseGymService;
        public ExerciseGymServices(WebApplicationGymDbContext exerciseGym)
        {
            _exerciseGymService = exerciseGym;
        }
        public List<ExerciseGym> GetAll() 
        {
            var exerciseGym = _exerciseGymService.exerciseGyms.ToList();
            return exerciseGym;
        }
        public int Save(ExerciseGym exercise)
        {
            _exerciseGymService.Add(exercise);
            _exerciseGymService.SaveChanges();
            return 1;
        }
    }
}
