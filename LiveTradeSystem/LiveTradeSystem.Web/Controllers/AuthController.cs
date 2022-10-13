using Microsoft.AspNetCore.Mvc;

namespace LiveTradeSystem.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
