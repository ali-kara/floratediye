using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTradeSystem.Entities.Concrete
{
    [Table("DepoGiris")]
    public class DepoGiris
    {
        [Key]
        public int Id { get; set; }

        public int UrNo { get; set; }

        [StringLength(20)]
        public string? BagNo { get; set; }

        public int? Nakliye { get; set; }

        public int? B_KovaAdet { get; set; }

        public int? K_KovaAdet { get; set; }

        [StringLength(10)]
        public string? Saat { get; set; }

        public int? CicekKodu { get; set; }

        [StringLength(20)]
        public string? Cinsi { get; set; }

        public int? Demet { get; set; }

        public int? D_SiraNo { get; set; }


        [StringLength(20)]
        public string? Nakliyeci { get; set; }

        [StringLength(5)]
        public string? Bilgi1 { get; set; }

        [StringLength(20)]
        public string? Ozellik1 { get; set; }

        [StringLength(20)]
        public string? Ozellik2 { get; set; }

        [StringLength(20)]
        public string? Ozellik3 { get; set; }

        [StringLength(20)]
        public string? Ozellik4 { get; set; }

        [StringLength(20)]
        public string? Ozellik5 { get; set; }

        [StringLength(20)]
        public string? Ozellik6 { get; set; }

        [StringLength(20)]
        public string? Ozellik7 { get; set; }

    }
}