using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;


namespace EcommerceCore.Controllers
{
    [Authorize]
    public class AdressController : Controller
    {
        CityManager cm = new CityManager(new EfCityRepository());
        ProvinceManager pm = new ProvinceManager(new EfProvinceRepository());
        AddressManager adm = new AddressManager(new EfAddressRepository());
        private readonly UserManager<User> _userManager;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCityList()
        {
            var values = cm.GetList();
            var result = JsonConvert.SerializeObject(values);
            return Json(result);
        }
        public IActionResult GetProviceListByCityId(int id)
        {
            var values = pm.GetProvinceListByCityId(id);
            var result = JsonConvert.SerializeObject(values);
            return Json(result);
        }
        [HttpPost]
        public IActionResult AddAddress(Address p)
        {
            //var id = _userManager.GetUserId(User);
            
            p.Status = true;
            //p.UserId = Int16.Parse(id);
            adm.TAdd(p);
            return View();
        }

    }
}
