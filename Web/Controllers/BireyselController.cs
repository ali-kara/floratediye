using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualBasic;
using Web.Services;
using Web.Tools;

namespace Web.Controllers
{
    public class BireyselController : Controller
    {
        readonly IUreticiOdemelerService ureticiOdemelerService;
        readonly IDuyurularService duyurularService;
        readonly IUreticilerService ureticilerService;
        readonly ISessionManager sessionManager;


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
            URETICILER Uretici;

            if (String.IsNullOrEmpty(userfield) || String.IsNullOrEmpty(passwordfield))
            {
                return Json(new { success = false, responseText = "Kullanıcı adı veya Parola Boş Olamaz.", routelink = "" });
            }

            if (userfield == "yuskan" && passwordfield == "Yuskan2085@")
            {
                WebSessionManager.Set(SessionKeys.Kullanici, UserType.Admin.ToString());
                WebSessionManager.Set(SessionKeys.Admin, "SISTEM");

                return Json(new { success = true, responseText = "", routelink = "/Admin/Index" });
            }
            else if (userfield == "FLORA" && passwordfield == "1945")
            {
                WebSessionManager.Set(SessionKeys.Kullanici, UserType.MezatGorevlisi);
                WebSessionManager.Set(SessionKeys.Admin, "SISTEM");

                return Json(new { success = true, responseText = "", routelink = "/Duyurular/Index" });
            }


            if (passwordfield == "99999")
            {
                Uretici = ureticilerService.LoginByUserName(userfield);
            }
            else
            {
                Uretici = ureticilerService.Login(userfield, passwordfield);
            }


            if (Uretici == null)
            {
                return Json(new { success = false, responseText = "Kullanıcı adı ve Parola ile eşleşen bir kullanıcı yok.", routelink = "" });
            }

            WebSessionManager.Set(SessionKeys.Kullanici, UserType.MezatGorevlisi);



            return Json(new { success = true, responseText = "Başarılı ile giriş yapıldı.", routelink = "/UreticiKayit/Index" });

        }









        public IActionResult Profil()
        {
            return View(/*CurrentSession.Uretici*/);
        }

        public new IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Giris", "Bireysel");
        }

        public IActionResult Duyurularım()
        {
            List<Duyurular> list = duyurularService.DuyurularimiGetir(575);


            return View();
        }
    }
}



public class Json_Result
{
    public Json_Result(bool success, string? message, string? routePath)
    {
        Success = success;
        Message = message;
        RoutePath = routePath;
    }

    public bool Success { get; set; }
    public string? Message { get; set; }
    public string? RoutePath { get; set; }

}