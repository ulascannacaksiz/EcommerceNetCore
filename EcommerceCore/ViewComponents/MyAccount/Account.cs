using EcommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.MyAccount
{
    public class Account:ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public Account(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var values =  _userManager.FindByNameAsync(User.Identity.Name).Result;
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.name = values.Name;
            model.surname = values.Surname;
            model.email = values.Email;
            model.username = values.UserName;

            return View(model);

        }
    }
}
