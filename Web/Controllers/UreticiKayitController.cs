using System.ComponentModel.DataAnnotations;
using System.Globalization;
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


        [HttpPost]
        public IActionResult GetUserRecord([FromBody]Deneme deneme)
        {
            List<ur_toplam> list = ureticiKayitService.Getir(575, deneme.dateStart.Date, deneme.dateEnd.Date);

            return PartialView("kayitbaslik", list);
        }

        [HttpPost]
        public IActionResult kayitdetay([FromBody]KayitDetayRequest kayitDetayRequest)
        {
            DateTime date = DateTime.Parse(kayitDetayRequest.tarih);

            List<satis> list = satisService.GetDetailList(575, kayitDetayRequest.sube, date.Date, kayitDetayRequest.sira_no);

            return PartialView("kayitdetay", list);
        }
    }

    public class Deneme
    {
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
    }

    public class KayitDetayRequest
    {
        public string sube { get; set; }
        public string tarih { get; set; }
        public int sira_no { get; set; }
    }
}
