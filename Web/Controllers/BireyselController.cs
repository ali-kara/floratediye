using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualBasic;
using Web.Tools;

namespace Web.Controllers
{
    public class BireyselController : Controller
    {
        IUreticiOdemelerService ureticiOdemelerService;

        IDuyurularService duyurularService;

        public BireyselController(IUreticiOdemelerService ureticiOdemelerService, IDuyurularService duyurularService)
        {
            this.ureticiOdemelerService = ureticiOdemelerService;
            this.duyurularService = duyurularService;
        }

        public ActionResult Odemelerim()
        {
            List<URETICI_ODEMELER2> Model = ureticiOdemelerService.UreticiOdemeGetir(575);

            return View(Model);
        }

        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(string User, string Password)
        {
            TempData["user"] = User;
            URETICILER uretici;

            if (User == string.Empty || Password == string.Empty)
            {
                ViewBag.Result = "Kullanıcı Adı veya Şifre Boş Olamaz.";
                ViewBag.Status = "danger";

                return View();
            }

            return RedirectToAction("Index", "UreticiKayit");
        }

        public ActionResult Profil()
        {
            return View(/*CurrentSession.Uretici*/);
        }

        public ActionResult SignOut()
        {
            //CurrentSession.Clear();

            return RedirectToAction("Giris", "Bireysel");
        }

        public IActionResult Duyurularım()
        {
            List<Duyurular> list = duyurularService.DuyurularimiGetir(575);


            return View();
        }
    }
}
