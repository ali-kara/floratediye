using Business.Abstract;
using Entities.Concrete;
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

        public ActionResult Profil()
        {
            return View(/*CurrentSession.Uretici*/);
        }
    }
}
