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
        [HttpGet]
        public IActionResult List()
        {
            var dietList=_diet.GetAll();
            return View(dietList);
        }
        [HttpGet]
        public IActionResult Details(Guid Id)
        {
            var dietDetails = _diet.Get(Id);
            return View(dietDetails);  
        }
        [HttpPost]
        public IActionResult Delete(Guid Id)
        {
            _diet.Delete(Id);
            return RedirectToAction("List");
        }
        
    }
}
