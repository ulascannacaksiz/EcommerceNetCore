using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Home
{
    public class TopSelling:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
