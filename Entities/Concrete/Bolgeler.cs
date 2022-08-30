using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("Bolgeler")]
    public class Bolgeler : BaseEntity
    {
        [Key]
        public int BolgeId { get; set; }

        [Required]
        [StringLength(10)]
        public string BolgeAdi { get; set; }

        [StringLength(50)]
        public string? Aciklama { get; set; }
    }
}
