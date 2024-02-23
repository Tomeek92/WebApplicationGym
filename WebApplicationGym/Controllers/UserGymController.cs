
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationGym.Models.Gym;


namespace WebApplicationGym.Controllers
{
    public class UserGymController : Controller
    {
      
        private readonly UserManager<UserGym> _userManager;
        private readonly SignInManager<UserGym> _signInManager;
        public UserGymController(UserManager<UserGym> userManager,SignInManager<UserGym> signInManager)
        {
            _userManager = userManager;  
            _signInManager = signInManager;
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
        public async Task <IActionResult> Login(Models.Logins.Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
         await _signInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);

return RedirectToAction("Index","Home");

        }
        [HttpGet]
        public IActionResult Login()
        {
            TempData["Message"] = "Zostałeś zalogowany";
            return View();  
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["Message"] = "Zostałeś wylogowany";
            return RedirectToAction("Index", "Home");
        }





    }
}
