using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyOrders()
        {
            return View();
        }
    }
}
