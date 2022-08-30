using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Concrete
{
    [Table("URETICILER")]
    public class URETICILER : BaseEntity
    {
        [Key]
        public int URETICI_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string URETICI_NO { get; set; }

        [Required]
        [StringLength(50)]
        public string ADI { get; set; }

        [StringLength(50)]
        public string SOYADI { get; set; }

        [Required]
        [StringLength(11)]
        public string TCKIMLIK_NO { get; set; }

        public DateTime? DOGUM_TARIHI { get; set; }

        [StringLength(50)]
        public string DOGUM_YERI { get; set; }

        [StringLength(20)]
        public string CEP_TELEFONU { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(30)]
        public string IL { get; set; }

        [StringLength(200)]
        public string ADRES { get; set; }

        [StringLength(50)]
        public string BAGKUR_NO { get; set; }

        [StringLength(10)]
        public string Yetki { get; set; }

        [StringLength(10)]
        public string Parola { get; set; }
    }
}
