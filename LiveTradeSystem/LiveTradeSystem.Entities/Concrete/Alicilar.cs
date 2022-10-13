using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTradeSystem.Entities.Concrete
{
    [Table("Alicilar")]
    public class Alicilar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? AliciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string? Parola { get; set; }

        public int? AliciCariKodu { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; }
    }
}
