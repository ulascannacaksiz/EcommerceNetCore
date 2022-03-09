using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceCore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id)
        {
            ProductManager pm = new ProductManager(new EfProductRepository());
            var values = pm.GetProductAllWithImage().Where(p=>p.CategoryId==id).ToList();

            return View(values);
        }
    }
}
