﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class DuyurularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
