using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceCore.Controllers
{
    public class CartController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public class Cookie{
            public int Id { get; set; }
            public int Total { get; set; }
        }
        public class CookieItem
        {
            public List<Cookie> Cookies { get; set; }
        }

        public IActionResult Index()
        {
            var cookiecart = HttpContext.Request.Cookies["cart"];
            var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);//BURASI DÜZGÜN ÇALIŞIYOR BURDAN GERİ KALAN İŞLEMLERİ YAP ALTAKİ FOREACH ÇALIŞIYPOR
            var values = pm.GetProductAllWithImage();
            List<Product> products = new List<Product>();
            ViewBag.v1 = list;
            if (cookiecart != null)
            {
               
                foreach (var item in list)
                {
                    products.Add(values.Where(x => x.Id == item.Id).FirstOrDefault());
                }
                return View(products);
            }

            return View();

        }

        [HttpPost]
        public IActionResult AddToChart(string productId,string q)
        {
            /*
            var cookiecart1 = "id:" + "1" + "q:" + "5";
            var result = JsonConvert.SerializeObject(cookiecart1);
            HttpContext.Response.Cookies.Append("cart", result);
             */
            
            string cookiecart = HttpContext.Request.Cookies["cart"];
            if (cookiecart != null)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);
                //List<Cookie> cookies = new List<Cookie>();
                list.Add(new Cookie()
                {
                    Id = Convert.ToInt32(productId),
                    Total=Convert.ToInt32(q),
                });
                var result = JsonConvert.SerializeObject(list);
                HttpContext.Response.Cookies.Append("cart", result);
            }
            else
            {
                List<Cookie> cookies = new List<Cookie>();
                cookies.Add(new Cookie()
                {
                    Id = Convert.ToInt32(productId),
                    Total = Convert.ToInt32(q),
                });
                var result = JsonConvert.SerializeObject(cookies);
                HttpContext.Response.Cookies.Append("cart", result);
                return Json(result);
            }
            return Json("Başarılı");
        }
    }
}
