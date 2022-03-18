using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.MyAccount
{
    public class Address:ViewComponent
    {
        AddressManager adm = new AddressManager(new EfAddressRepository());
        public IViewComponentResult Invoke()
        {
            var values = adm.GetListAddressesByParameter(4);
            return View(values);
        }
    }
}
