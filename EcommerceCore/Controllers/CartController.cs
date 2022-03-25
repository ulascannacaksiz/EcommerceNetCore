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
        public class Cookie
        {
            public int Id { get; set; }
            public int Total { get; set; }
        }
        //public class CookieItem
        //{
        //    public List<Cookie> Cookies { get; set; }
        //}

        public IActionResult Index()
        {
            var cookiecart = HttpContext.Request.Cookies["cart"];
            var values = pm.GetProductAllWithImage();
            List<Product> products = new List<Product>();

            if (cookiecart != null)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);//BURASI DÜZGÜN ÇALIŞIYOR BURDAN GERİ KALAN İŞLEMLERİ YAP ALTAKİ FOREACH ÇALIŞIYPOR
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

        [HttpPost]
        public IActionResult AddToChart(string productId, string q)
        {
            string cookiecart = HttpContext.Request.Cookies["cart"];
            if (cookiecart != null && cookiecart != "[]" && Convert.ToInt32(productId) != 0)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);
                foreach (var item in list)
                {
                    if (item.Id.ToString() != productId)
                    {
                        list.Add(new Cookie()
                        {
                            Id = Convert.ToInt32(productId),
                            Total = Convert.ToInt32(q),
                        });
                        var result = JsonConvert.SerializeObject(list);
                        HttpContext.Response.Cookies.Append("cart", result);
                        return Json(result);
                    }
                    else
                    {
                        if (Convert.ToInt32(productId) != 0)
                        {
                            var selecteditem = list.FirstOrDefault(x => x.Id.ToString() == productId);
                            selecteditem.Total += Convert.ToInt32(q);
                            var result = JsonConvert.SerializeObject(list);
                            HttpContext.Response.Cookies.Append("cart", result);
                            return Json(result);
                        }
                    }
                }

            }
            else if (cookiecart == "[]" && Convert.ToInt32(productId) != 0)
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

        [HttpPost]
        public IActionResult UpdateCart(string productId, string q)
        {
            var cookiecart = HttpContext.Request.Cookies["cart"];
            if (cookiecart != null)
            {
                var list = JsonConvert.DeserializeObject<List<Cookie>>(cookiecart);

                if (Convert.ToInt32(q) != 0)
                {
                    var selecteditem = list.FirstOrDefault(x => x.Id.ToString() == productId);
                    selecteditem.Total = Convert.ToInt32(q);
                    var result = JsonConvert.SerializeObject(list);
                    HttpContext.Response.Cookies.Append("cart", result);
                }
                else
                {
                    var itemToRemove = list.Single(r => r.Id == Convert.ToInt32(productId));
                    list.Remove(itemToRemove);
                    var result = JsonConvert.SerializeObject(list);
                    HttpContext.Response.Cookies.Append("cart", result);
                }

            }
            return Json("Başarılı");
        }
    }
}
