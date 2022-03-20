using EcommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EcommerceCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public LoginController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(p.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, p.Password, false, true);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "MyAccount");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            return View();
        }
    }
}