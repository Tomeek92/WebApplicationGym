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

        public ExerciseGym Get(Guid Id)
        {
            var exerciseGym = _exerciseGymService.exerciseGyms.Find(Id);
            return exerciseGym;
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
       
        public Guid Delete(Guid Id)
        {
            var exerciseGym = _exerciseGymService.exerciseGyms.Find(Id);
            _exerciseGymService.exerciseGyms.Remove(exerciseGym);
            _exerciseGymService.SaveChanges();
            return Id;
        }
    }
}
