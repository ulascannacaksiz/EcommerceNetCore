using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Home
{
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
