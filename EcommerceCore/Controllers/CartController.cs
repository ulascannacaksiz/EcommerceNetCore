using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceCore.Controllers
{
    public class CartController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            string cookiecart = HttpContext.Request.Cookies["cart"];

            var values = pm.GetProductAllWithImage();
            List<Product> deneme = new List<Product>();
            if (cookiecart != null)
            {
                string[] products = cookiecart.Split(',');
                foreach(var p in products)
                {
                    deneme.Add(values.Where(x => x.Id.ToString() == p).FirstOrDefault());
                }
                return View(deneme);
            }
            return View();

        }

        [HttpPost]
        public IActionResult AddToChart(string productId)
        {
            string cookiecart = HttpContext.Request.Cookies["cart"];
            if (cookiecart != null)
            {
                cookiecart += ',' + productId;
                HttpContext.Response.Cookies.Append("cart", cookiecart);
            }
            else
            {
                HttpContext.Response.Cookies.Append("cart", productId.ToString());
            }
            return Json("Başarılı");
        }
    }
}
