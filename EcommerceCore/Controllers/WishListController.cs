using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    public class WishListController : Controller
    {
        WhisListManager wl = new WhisListManager(new EfWhisListRepository());
        private readonly UserManager<User> _userManager;

        public WishListController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddWishList(WhisList p)
        {
            var user =  _userManager.FindByNameAsync(User.Identity.Name);
            if (user != null)
            {
                p.UserId = user.Result.Id;
                p.Status = true;
                wl.TAdd(p);
            }
            return Json("Ürün eklendi");
        }
    }
}
