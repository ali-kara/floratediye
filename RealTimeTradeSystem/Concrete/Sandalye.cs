using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeEntities
{
    [Table("Sandalye")]
    public class Sandalye
    {
        [Key]
        public int Id { get; set; }
        public int AliciCariKodu { get; set; }
        
        [StringLength(50)]
        public string? AliciAdi { get; set; }
        public bool IsActive { get; set; }
        public bool IsPressed { get; set; }
        public decimal KalanKredi { get; set; }
        public bool CheckActivate { get; set; }
        public DateTime? LoginTime { get; set; }

    }
}
