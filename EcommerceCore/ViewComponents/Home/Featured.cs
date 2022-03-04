using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Home
{
    public class Featured:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
