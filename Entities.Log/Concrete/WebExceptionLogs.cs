using Core.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Log.Concrete
{
	[Table("WebExceptionLogs")]
    public class WebExceptionLogs : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Hata No")]
        [Key]
        public int ExceptionID { get; set; }

        [DisplayName("Mesaj")]
        public string Message { get; set; }

        [DisplayName("Hata İç Detayı")]
        public string InnerException { get; set; }

        [DisplayName("Hata Detayı")]
        public string Stacktrace { get; set; }

        [DisplayName("Action")]
        [StringLength(100)]
        public string ActionName { get; set; }

        [DisplayName("Controller")]
        [StringLength(100)]
        public string Controller { get; set; }
    }
}