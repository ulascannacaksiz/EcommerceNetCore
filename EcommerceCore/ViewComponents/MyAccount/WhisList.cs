using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.MyAccount
{
    public class WhisList:ViewComponent
    {
        WishListManager wl = new WishListManager(new EfWishListRepository());
        private readonly UserManager<User> _userManager;

        public WhisList(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name);
            var values = wl.GetListByUserId(user.Result.Id);
            return View(values);
        }
    }
}
