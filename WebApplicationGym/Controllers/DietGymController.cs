using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;
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
