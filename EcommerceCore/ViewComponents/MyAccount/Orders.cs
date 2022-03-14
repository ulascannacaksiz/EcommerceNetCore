using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.MyAccount
{
    public class Orders:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
