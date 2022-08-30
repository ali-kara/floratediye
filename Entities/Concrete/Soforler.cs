using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    [Table("Soforler")]
    public class Soforler : BaseEntity
    {
        [Key]
        public int SoforID { get; set; }

        [Required]
        [StringLength(20)]
        public string Kodu { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string Soyadi { get; set; }

        [StringLength(10)]
        public string? Plaka { get; set; }

        [StringLength(30)]
        public string? Sehir { get; set; }

        [StringLength(30)]
        public string? Bolge { get; set; }

        [StringLength(20)]
        [JsonIgnore]
        public string? Parola { get; set; }

        [StringLength(50)]
        public string? Nakliyeci { get; set; }
    }
}
