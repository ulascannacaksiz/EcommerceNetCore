using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EcommerceCore.Controllers
{
    public class WishListController : Controller
    {
        WishListManager wl = new WishListManager(new EfWishListRepository());
        private readonly UserManager<User> _userManager;

        public WishListController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddWishList(WhisList p)
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name);
            var list = wl.GetList();
            if (user != null)
            {

                p.UserId = user.Result.Id;
                var usersItem = list.Where(x => x.UserId == p.UserId);
                var result = usersItem.Where(y => y.ProductId == p.ProductId).Where(c=>c.Status==true).ToList();
                if (result.Count == 0)
                {
                    p.Status = true;
                    wl.TAdd(p);

                    JArray array = new JArray();
                    JValue type = new JValue("success");
                    JValue title = new JValue("Başarılı");
                    JValue message = new JValue("Ürün istek listenize eklendi");

                    array.Add(type);
                    array.Add(title);
                    array.Add(message);
                    return Json(JsonConvert.SerializeObject(array));
                }
                else
                {
                    JArray array = new JArray();
                    JValue type = new JValue("error");
                    JValue title = new JValue("Hata");
                    JValue message = new JValue("Ürün zaten istek listenizde!");

                    array.Add(type);
                    array.Add(title);
                    array.Add(message);
                    return Json(JsonConvert.SerializeObject(array));
                }

            }
            JArray array1 = new JArray();
            JValue type1 = new JValue("error");
            JValue title1 = new JValue("Hata");
            JValue message1 = new JValue("Lütfen giriş yapınız!");

            array1.Add(type1);
            array1.Add(title1);
            array1.Add(message1);
            return Json(JsonConvert.SerializeObject(array1));
        }

        [Authorize]
        [HttpPost]
        public IActionResult RemoveItem(int id)
        {
            var  item = wl.TGetById(id);
            item.Status = false;
            wl.TUpdate(item);
            return Json("Başarılı");
        }
    }
}
