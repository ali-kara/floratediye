using Core.Entities;
using Entities.Log.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Log.Concrete
{
	[Table("WebSessionLogs")]
    public class WebSessionLogs : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Kayıt No")]
        [Key]
        public int Web_Session_Logs_ID { get; set; }

        [DisplayName("IP Adresi")]
        [StringLength(16)]
        public string IpAdres { get; set; }

        [DisplayName("Yapılan İşlem")]
        public OturumHareket YapılanIslem { get; set; }

        [DisplayName("Kullanıcı No")]
        public int? UserID { get; set; }

        public virtual Users kullanicilar { get; set; }
    }


}
