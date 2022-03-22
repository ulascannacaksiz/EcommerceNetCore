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
            //var cartItem=Product;
            List<Product> deneme = new List<Product>();
            if (cookiecart != null)
            {
                string[] products = cookiecart.Split(',');
                foreach(var p in products)
                {
                    // cartItem += values.Find(x=>x.Id.ToString() == p);
                    deneme.Add(values.Where(x => x.Id.ToString() == p).FirstOrDefault());
                }
                return View(deneme);
            }
            return View();

        }

        public IActionResult AddToChart(int product_id)
        {
            string cookiecart = HttpContext.Request.Cookies["cart"];
            if (cookiecart != null)
            {
                cookiecart += ',' + product_id;
                HttpContext.Response.Cookies.Append("cart", cookiecart);
            }
            else
            {
                HttpContext.Response.Cookies.Append("cart", product_id.ToString());
            }
            return View();
        }
    }
}
