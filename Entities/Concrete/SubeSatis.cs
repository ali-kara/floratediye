using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class SubeSatis : IEntity
    {
        [Key]
        public int SubeID { get; set; }

        [StringLength(20)]
        public string? SubeAdi { get; set; }

        [StringLength(10)]
        [DisplayName("�ube")]
        public string? SubeKisaAdi { get; set; }

        [DisplayName("Toplam Tutar")]
        public decimal? ToplamTutar { get; set; }

        [DisplayName("Ortalama")]
        public decimal? Ortalama { get; set; }

        [DisplayName("Toplam Koli Say�s�")]
        public int? ToplamKoliSayisi { get; set; }

        [DisplayName("Sat�lan Koli Say�s�")]
        public int? SatilanKoliSayisi { get; set; }

        [DisplayName("Kalan Koli Say�s�")]
        public int? KalanKoliSayisi { get; set; }

        [DisplayName("M��teri Say�s�")]
        public int? MusteriSayisi { get; set; }

        [DisplayName("Tarih")]
        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        [StringLength(250)]
        [DisplayName("A��klama")]
        public string? Aciklama { get; set; }
    }
}
