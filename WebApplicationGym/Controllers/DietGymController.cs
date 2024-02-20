using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;
using WebApplicationGym.Models.Gym;
using WebApplicationGym.Models.Validators;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Controllers
{
    public class DietGymController : Controller
    {
        private readonly IDietGymServices _dietGym;
        public DietGymController(IDietGymServices dietGym)
        {
           _dietGym = dietGym;
        }
        [HttpGet]
        [Route("Diet-gym")]
        public IActionResult DietGym()
        {
            return View();
        }
        [HttpPost]
        [Route("Diet-gym")]
        public IActionResult DietGym(DietGym body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }
            var validator = new DietGymValidator();
            validator.ValidateAndThrow(body);

            var id = _dietGym.Save(body);
            ViewBag.SuccessMessage = "Twoja dieta została dodana";
            return View(body);
        }
        
        

      
    }
}
