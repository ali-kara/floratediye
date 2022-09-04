using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Log.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class BireyselController : Controller
    {
        IUreticiOdemelerService ureticiOdemelerService;
        public BireyselController(IUreticiOdemelerService ureticiOdemelerService)
        {
            this.ureticiOdemelerService = ureticiOdemelerService;
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
    }
}
