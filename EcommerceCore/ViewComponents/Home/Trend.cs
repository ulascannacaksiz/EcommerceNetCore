using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Home
{
    public class Trend:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
