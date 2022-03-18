using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    [Authorize]
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
