using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceCore.ViewComponents.Home
{
    public class CartDropdown:ViewComponent
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public class Cookie
        {
            public int Id { get; set; }
            public int Total { get; set; }
        }
        public IViewComponentResult Invoke()
        {
            var cookiecart = HttpContext.Request.Cookies["cart"];
            var values = pm.GetProductAllWithImage();
            List<EntityLayer.Concrete.Product> products = new List<EntityLayer.Concrete.Product>();
            if (cookiecart != null)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);
                ViewBag.v1 = list;
                foreach (var item in list)
                {
                    if (item.Id != 0)
                    {
                        products.Add(values.Where(x => x.Id == item.Id).FirstOrDefault());
                    }
                }
                return View(products);
            }

            return View();
        }
    }
}
