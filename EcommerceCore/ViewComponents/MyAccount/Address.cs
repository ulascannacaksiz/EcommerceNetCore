using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceCore.ViewComponents.MyAccount
{
    public class Address:ViewComponent
    {
        AddressManager adm = new AddressManager(new EfAddressRepository());
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            Context c = new Context();
            var user = c.Users.Where(u => u.UserName == username).FirstOrDefault();
            var values = adm.GetListAddressesByParameter(user.Id);
            ViewBag.Adres = values;
            return View();
        }
    }
}
