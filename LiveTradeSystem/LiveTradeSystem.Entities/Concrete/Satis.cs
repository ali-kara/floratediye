using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LiveTradeSystem.Entities.Concrete
{
    public class Satis
    {
        public int Id { get; set; }
        public int? SiraNo { get; set; }
        public int CicekKodu { get; set; }

        [StringLength(20)]
        public string? CicekAdi { get; set; }
        public int? CicekDemet { get; set; }
        public int? CicekAdet { get; set; }
        public int? ToplamAdet { get; set; }

        public decimal? SatisFiyat { get; set; }
        public decimal? ToplamTutar { get; set; }

        public int? UreticiKodu { get; set; }
        public int? AliciSandalye { get; set; }
        public int? AliciKodu { get; set; }

        [StringLength(5)]
        public string? FaturaYaz { get; set; }
        public int? S_SNo { get; set; }

        public decimal? DalFiyat { get; set; }

    }
}
