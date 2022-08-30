using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class TombalaInsertDTO : IDto
    {
        public string? Sofor_Kodu { get; set; }
        public string? Bolge { get; set; }
        public string? Plaka { get; set; }
        public string? Adet { get; set; }
        public string? UreticiKodu { get; set; }
        public string? Barkod { get; set; }

    }
}
