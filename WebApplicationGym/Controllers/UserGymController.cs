
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using WebApplicationGym.Models.Gym;
using WebApplicationGym.Models.Register;


namespace WebApplicationGym.Controllers
{
    public class UserGymController : Controller
    {
      
        private readonly UserManager<UserGym> _userManager;
        public UserGymController(UserManager<UserGym> userManager)
        {
            _userManager = userManager;  
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
        public async Task<IActionResult> UserGym(Models.Register.Register body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }
           
            
            ViewBag.SuccessMessage = "Twoje konto zostało utworzone";
            var newUserGym = new UserGym
            {
                UserName = body.Name,
                Email = body.Email,
                Name = body.Name,
                Address = body.Address,
                Surname = body.Surname,
                Password = body.Password
            };
            
           var result = await _userManager.CreateAsync(newUserGym, body.Password);
            if (result.Succeeded)
            {
                // Użytkownik został pomyślnie utworzony
            }
            else
            {
                // Coś poszło nie tak, wyświetl błędy
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.Description);
                }
            }

            return View(body);
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();  
        }
        
        public IActionResult Logout()
        {
            return View();
        }
      
       
        


    }
}
