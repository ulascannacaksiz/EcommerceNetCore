using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Home
{
    public class Deal:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
