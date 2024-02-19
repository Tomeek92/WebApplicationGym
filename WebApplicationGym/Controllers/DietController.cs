using Microsoft.AspNetCore.Mvc;
using WebApplicationGym.Services.Interfaces;

namespace WebApplicationGym.Controllers
{
    public class DietController : Controller
    { 
            private readonly IDietGymServices _diet;
            public DietController(IDietGymServices diet)
            {
                _diet = diet;
            }
            public IActionResult List()
            {
                var dietList = _diet.GetAll();
                return View(dietList);
            }
        
    }
}
