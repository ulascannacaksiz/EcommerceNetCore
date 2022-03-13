using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult MyOrders()
        {
            return View();
        }
    }
}
