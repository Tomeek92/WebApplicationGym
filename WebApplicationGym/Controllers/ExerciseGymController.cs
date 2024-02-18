using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApplicationGym.Models.Gym;
using WebApplicationGym.Models.Validators;
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
        [HttpGet]
        [Route("Exercise-gym")]
        public IActionResult ExerciseGym()
        {
            return View();
        }

        [HttpPost]
        [Route("Exercise-gym")]
        public IActionResult ExerciseGym(ExerciseGym body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }
            var validator = new ExerciseGymValidator();
            validator.ValidateAndThrow(body);
            return View(body);
        }
        
    }
}
