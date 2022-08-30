using Entities.Log.Abstract;
using Entities.Log.Concrete;

namespace Entities.Log.DTO
{
    public class DuyurularDTO : BaseViewModel
    {
        public Duyurular duyurular { get; set; }
        public string[] sehirler { get; set; }
    }
}
