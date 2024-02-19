using Microsoft.AspNetCore.Mvc;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseGymService _exerciseGymService;
        public ExerciseController(IExerciseGymService exerciseGym)
        {
            _exerciseGymService = exerciseGym;
        }
        public IActionResult List()
        {
            var exerciseList = _exerciseGymService.GetAll();
            return View(exerciseList);
        }
    }
}
