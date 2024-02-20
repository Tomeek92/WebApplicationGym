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
        [HttpGet]
        public IActionResult List()
        {
            var exerciseList = _exerciseGymService.GetAll();
            return View(exerciseList);
        }
        [HttpGet]
        public IActionResult Details(Guid Id)
        {
            var exerciseDetails = _exerciseGymService.Get(Id);
           return View(exerciseDetails);
        }
        [HttpPost]
        public IActionResult Delete(Guid Id) 
        {
            var exerciseDelete = _exerciseGymService.Delete(Id);
            return RedirectToAction("List");
        }

    }
}
