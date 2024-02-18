using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGym.Controllers
{
    public class OpinionsController : Controller
    {
        public IActionResult Opinions()
        {
            return View();  
        }
    }
}
