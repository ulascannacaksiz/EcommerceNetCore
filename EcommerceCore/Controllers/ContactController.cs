using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            ContactValidator cv = new ContactValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.Status = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    //return Json(JsonConvert.SerializeObject(item.ErrorMessage));
                }
            }
            return View();
        }
    }
}
