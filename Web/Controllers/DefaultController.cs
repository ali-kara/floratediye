﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
