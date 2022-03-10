using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceCore.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Index(int id)
        {
            ProductManager pm = new ProductManager(new EfProductRepository());
            var values = pm.GetProductAllWithImage().Where(p=>p.CategoryId==id).ToList();
            var brands = values.Select(x => x.Brand);
            ViewBag.Brands = brands;
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(int id, string brands)
        {
            //decimal minPrice, decimal? maxPrice, string[] colors,
            ProductManager pm = new ProductManager(new EfProductRepository());
            var values = pm.GetProductAllWithImage().Where(p => p.CategoryId == id).Where(p => brands.Contains(p.Brand)).ToList();
            var brands1 = values.Where(p => brands.Contains(p.Brand));
            ViewBag.Brands = brands1;
            return View(values);
        }
    }
}
