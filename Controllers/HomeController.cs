﻿using Microsoft.AspNetCore.Mvc;

namespace Bullbol.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpcomingEvents()
        {
            return View();
        }
        public IActionResult Archive()
        {
            return View();
        }
    }
}
