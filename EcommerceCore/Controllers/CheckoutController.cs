﻿using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
