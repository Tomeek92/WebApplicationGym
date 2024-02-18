using Microsoft.AspNetCore.Mvc;

namespace WebApplicationGym.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
