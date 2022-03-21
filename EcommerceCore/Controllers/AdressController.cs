using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCore.Controllers
{
    [Authorize]
    public class AdressController : Controller
    {
        private CityManager cm = new CityManager(new EfCityRepository());
        private ProvinceManager pm = new ProvinceManager(new EfProvinceRepository());
        private AddressManager adm = new AddressManager(new EfAddressRepository());
        private readonly UserManager<User> _userManager;

        public AdressController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

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
        public async Task<IActionResult> AddAddress(Address p)
        {
            AddressValidator av = new AddressValidator();
            ValidationResult results = av.Validate(p);
            if (results.IsValid)
            {
                var username = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(username);
                p.Status = true;
                p.UserId = user.Id;
                adm.TAdd(p);
                return Json(JsonConvert.SerializeObject("Başarılı"));
            } else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    return Json(JsonConvert.SerializeObject(item.ErrorMessage));
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetAddressByAddressId(int id)
        {
            var username = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(username);
            var values = adm.GetListAddressesByParameter(user.Id);
            var data = values.Where(x => x.Id == id);
            return Json(JsonConvert.SerializeObject(data));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAddress(Address p)
        {
            AddressValidator av = new AddressValidator();
            ValidationResult results = av.Validate(p);
            if (results.IsValid)
            {
                var username = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(username);
                var values = adm.GetListAddressesByParameter(user.Id);
                var data = values.Where(x => x.Id == p.Id);
                if (data != null)
                {
                    p.Status = true;
                    p.UserId = user.Id;
                    adm.TUpdate(p);
                    return Json(JsonConvert.SerializeObject("Başarılı"));
                }
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    return Json(JsonConvert.SerializeObject(item.ErrorMessage));
                }

            }

            return View();
        }
    }
}