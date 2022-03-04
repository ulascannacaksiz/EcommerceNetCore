using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Home
{
    public class Navbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
