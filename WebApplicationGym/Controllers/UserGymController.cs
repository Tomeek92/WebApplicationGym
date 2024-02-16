using Microsoft.AspNetCore.Mvc;
using WebApplicationGym.Models.Gym;
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
        
        public IActionResult UserGym()
        {
            return View();
            
        }
       
        


    }
}
