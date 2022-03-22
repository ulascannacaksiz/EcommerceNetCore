using EcommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EcommerceCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
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
        public async Task<IActionResult> Index(RegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                User u = new User
                {
                    Name = p.Name,
                    Surname = p.SurName,
                    Email = p.Email,
                    BirthDate = p.BirthDate,
                    UserName = p.UserName,
                };
                var result = await _userManager.CreateAsync(u, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }

                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel p)
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
                        return RedirectToAction("Index", "Account");
                    }
                }
            }
            return RedirectToAction("Index", "Account");
        }
    }
}
