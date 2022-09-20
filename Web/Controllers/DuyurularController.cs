using Business.Abstract;
using Entities.Log.Concrete;
using Entities.Log.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class DuyurularController : Controller
    {
        IDuyurularService duyurularService;

        public DuyurularController(IDuyurularService duyurularService)
        {
            this.duyurularService = duyurularService;
        }

        public IActionResult Index()
        {
            List<DuyurularDTO> list = duyurularService.DuyurulariGetir();
            return View(list);
        }

        public IActionResult Yeni()
        {
            return View();
        }


    }
}
