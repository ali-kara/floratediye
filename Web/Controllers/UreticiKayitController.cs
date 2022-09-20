using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UreticiKayitController : Controller
    {
        IUreticiKayitService ureticiKayitService;

        ISatisService satisService;


        public UreticiKayitController(IUreticiKayitService ureticiKayitService, ISatisService satisService)
        {
            this.ureticiKayitService = ureticiKayitService;
            this.satisService = satisService;
        }

        public IActionResult Index()
        {
            List<ur_toplam> list = ureticiKayitService.Getir(575, DateTime.Now.AddYears(-4), DateTime.Now);

            return View(list);
        }

        public IActionResult kayitdetay(string sube, DateTime? tarih, int sira_no)
        {
            List<satis> list = satisService.GetDetailList(575, sube, tarih, sira_no);

            return View(list);
        }
    }
}
