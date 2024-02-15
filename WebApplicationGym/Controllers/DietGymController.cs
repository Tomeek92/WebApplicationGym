using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGym.Controllers
{
    public class DietGymController : Controller
    {
       
        [Route("Dietgym")]
        public IActionResult DietGym()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("DietGym");
        }
    }
}
