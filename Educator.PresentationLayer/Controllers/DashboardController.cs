﻿using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
