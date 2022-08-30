using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Log.Concrete
{

    [Table("SoforSessionLogs")]
    public class SoforSessionLogs : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string SoforKodu { get; set; }
        [StringLength(15)]
        public string IP { get; set; }
        public OturumHareket OturumHareket { get; set; }
    }
}


public enum OturumHareket
{
    [Description("Oturum Açıldı")]
    Oturum_Acildi,
    [Description("Oturum Kapatıldı")]
    Oturum_Kapatildi
}

