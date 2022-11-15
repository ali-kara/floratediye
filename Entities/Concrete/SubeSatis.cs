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
        [DisplayName("Şube")]
        public string? SubeKisaAdi { get; set; }

        [DisplayName("Toplam Tutar")]
        public decimal? ToplamTutar { get; set; }

        [DisplayName("Ortalama")]
        public decimal? Ortalama { get; set; }

        [DisplayName("Toplam Koli Sayısı")]
        public int? ToplamKoliSayisi { get; set; }

        [DisplayName("Satılan Koli Sayısı")]
        public int? SatilanKoliSayisi { get; set; }

        [DisplayName("Kalan Koli Sayısı")]
        public int? KalanKoliSayisi { get; set; }

        [DisplayName("Müşteri Sayısı")]
        public int? MusteriSayisi { get; set; }

        [DisplayName("Tarih")]
        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        [StringLength(250)]
        [DisplayName("Açıklama")]
        public string? Aciklama { get; set; }
    }
}
