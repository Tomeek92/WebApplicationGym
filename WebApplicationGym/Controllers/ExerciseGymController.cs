using Microsoft.AspNetCore.Mvc;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Controllers
{
    public class ExerciseGymController : Controller
    {
        private readonly IExerciseGymService _exerciseGymService;
        public ExerciseGymController(IExerciseGymService exerciseGymService)
        {
            _exerciseGymService = exerciseGymService;   
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Exercise-gym")]
        public IActionResult ExerciseGym()
        {
            return View();
        }
        
    }
}
