using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UreticiKayitController : Controller
    {
        IUreticiKayitService ureticiKayitService;

        public UreticiKayitController(IUreticiKayitService ureticiKayitService)
        {
            this.ureticiKayitService = ureticiKayitService;
        }

        public IActionResult Index()
        {
            List<ur_toplam> list = ureticiKayitService.Getir(575, DateTime.Now.AddYears(-4), DateTime.Now);

            return View(list);
        }
    }
}
