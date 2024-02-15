using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGym.Controllers
{
    public class ExerciseGymController : Controller
    {
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
