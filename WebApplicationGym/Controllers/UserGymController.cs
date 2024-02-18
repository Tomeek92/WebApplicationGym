using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApplicationGym.Models.Gym;
using WebApplicationGym.Models.Validators;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Controllers
{
    public class UserGymController : Controller
    {
        private readonly IUserGymService _userGymService;
        public UserGymController(IUserGymService userGym)
        {
            _userGymService = userGym; 
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("User-gym")]
        public IActionResult UserGym()
        {
            return View();
            
        }
        [HttpPost]
        [Route("User-gym")]
        public IActionResult UserGym(UserGym body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }
            var validator = new UserGymValidator();
            validator.ValidateAndThrow(body);
            return View(body);
        }
       
        


    }
}
