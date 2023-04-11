using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using static EcommerceCore.Controllers.CartController;

namespace EcommerceCore.Controllers
{
    public class CheckoutController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        OrderManager om = new OrderManager(new EfOrderRepository());
        private readonly UserManager<User> _userManager;
        Random rastgele = new Random();

        public CheckoutController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cookiecart = HttpContext.Request.Cookies["cart"];
            var values = pm.GetProductAllWithImage();
            int price = 0;
            if (cookiecart != null)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);
                foreach (var item in list)
                {
                    if (item.Id != 0)
                    {
                        var data = values.Where(x => x.Id == item.Id).Select(y => y.Price).FirstOrDefault();
                        price += Convert.ToInt32(data);
                    }
                }
            }
            ViewBag.p=price;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Order p)
        {
            var cookiecart = HttpContext.Request.Cookies["cart"];
            var values = pm.GetProductAllWithImage();
            var user = _userManager.FindByNameAsync(User.Identity.Name);
            p.UserId = user.Result.Id;
           // p.AddressId = 2;
            p.OrderNumber = rastgele.Next(100000000,999999999);
            p.OrderStatus = 1;
            p.OrderDateTime = DateTime.Now;
            p.PaymentMethod = "Kredi kartı";
            if (cookiecart != null)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);
                foreach (var item in list)
                {
                    if (item.Id != 0)
                    {
                        var data = values.Where(x => x.Id == item.Id).FirstOrDefault();
                        p.ProductId = data.Id;
                        p.Price= data.Price;
                    }
                }
            }
            om.TAdd(p);
            return View();
        }
    }
}
