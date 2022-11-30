using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
	public class AdminController : Controller
	{
		public AdminController()
		{
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}

