using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            var values = pm.GetProductDetailWithCategory(id);
            return View(values);
        }
    }
}
