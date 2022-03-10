using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EcommerceCore.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        RatingManager rm = new RatingManager(new EfRatingRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            var values = pm.GetProductDetailWithCategory(id);
            var rating = rm.GetListByProductId(id);
            if(rating != null)
            {
                int count = rating.Count();
                double ratingval = 0;
                if (count > 0)
                {
                    int total = rating.Select(x => x.Vote).Sum();
                    double avg = total / count;
                    ratingval = (Math.Round(avg, 1) * 20);
                }
                ViewBag.Rating = ratingval;
                ViewBag.Count = count;
                   
            }
            return View(values);
        }
    }
}
