using Entities.Log.Abstract;
using Entities.Log.Concrete;

namespace Entities.Log.DTO
{
    public class DuyurularDTO : BaseDTO
    {
        public Duyurular duyurular { get; set; }
        public string[] sehirler { get; set; }
    }
}
