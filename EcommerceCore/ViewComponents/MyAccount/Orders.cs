using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.MyAccount
{
    public class Orders:ViewComponent
    {
        OrderManager om = new OrderManager(new EfOrderRepository());
        public IViewComponentResult Invoke()
        {
            var values = om.GetOrderListByUser(4);
            return View(values);
        }
    }
}
