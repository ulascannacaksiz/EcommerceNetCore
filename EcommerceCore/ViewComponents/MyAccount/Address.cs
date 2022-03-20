using BusinessLayer.Concrete;
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
            var values = adm.GetListAddressesByParameter(4);
            ViewBag.Adres = values;
            return View();
        }
    }
}
