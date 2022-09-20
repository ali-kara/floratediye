using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        ISubeSatisService subeSatisService;

        public HomeController(ISubeSatisService subeSatisService)
        {
            this.subeSatisService = subeSatisService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Subeler()
        {
            var list = subeSatisService.GetAll();
            
            return View(list);
        }
    }
}
