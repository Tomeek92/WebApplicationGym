using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGym.Controllers
{
    public class UserGymController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("UserGym")]
        public IActionResult UserGym()
        {
            return View();
        }


    }
}
