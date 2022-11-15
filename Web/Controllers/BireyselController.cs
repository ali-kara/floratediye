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
        readonly IUreticiOdemelerService ureticiOdemelerService;

        readonly IDuyurularService duyurularService;

        readonly IUreticilerService ureticilerService;

        public BireyselController(IUreticiOdemelerService ureticiOdemelerService, IDuyurularService duyurularService, IUreticilerService ureticilerService)
        {
            this.ureticiOdemelerService = ureticiOdemelerService;
            this.duyurularService = duyurularService;
            this.ureticilerService = ureticilerService;
        }

        public IActionResult Odemelerim()
        {
            List<URETICI_ODEMELER2> Model = ureticiOdemelerService.UreticiOdemeGetir(575);



            return View(Model);
        }

        public IActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Giris(string userfield, string passwordfield)
        {
            if (String.IsNullOrEmpty(userfield) || String.IsNullOrEmpty(passwordfield))
            {
                //return Json(new JsonResult { Success = false, Message = "Kullanıcı adı veya Parola Boş Olamaz.", RoutePath = "/Admin/Index" });
                return Json(new { success = false, responseText = "Kullanıcı adı veya Parola Boş Olamaz.", routelink = "ada" });

            }


            return Json(new { success = false, responseText = "Kullanıcı adı ve Parola ile eşleşen bir kullanıcı yok." });


            //var uretici = ureticilerService.Login(userfield, passwordfield);

            //if (uretici == null)
            //{
            //    return Json(new { success = false, responseText = "Kullanıcı adı ve Parola ile eşleşen bir kullanıcı yok." });
            //}

            //if (userfield == "yuskan" && passwordfield == "Yuskan2085@")
            //{
            //    //CurrentSession.Set(SessionKeys.Kullanici, UserType.Admin);
            //    //CurrentSession.Set(SessionKeys.Admin, "SISTEM");

            //    return RedirectToAction("Index", "Admin");
            //}
            //else if (userfield == "FLORA" && passwordfield == "1945")
            //{
            //    //CurrentSession.Set(SessionKeys.Kullanici, UserType.MezatGorevlisi);
            //    //CurrentSession.Set(SessionKeys.Admin, "SISTEM");

            //    return RedirectToAction("Index", "Duyurular");
            //}





            //TempData["user"] = User;

            //return RedirectToAction("Index", "UreticiKayit");
        }









        public IActionResult Profil()
        {
            return View(/*CurrentSession.Uretici*/);
        }

        public IActionResult SignOut()
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



public class JsonResult
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public string? RoutePath { get; set; }

}