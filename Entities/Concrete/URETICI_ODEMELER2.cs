using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace Entities.Concrete
{
    public partial class URETICI_ODEMELER2 : BaseEntity
    {
        [Key]
        public int URETICI_ODEME_ID { get; set; }

        public int URETICI_ID { get; set; }

        public DateTime? TARIH { get; set; }

        [StringLength(50)]
        public string? ODEME { get; set; }

        [StringLength(50)]
        public string? ACIKLAMA { get; set; }
    }
}
