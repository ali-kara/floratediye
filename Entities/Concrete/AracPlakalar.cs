using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    [Table("AracPlakalar")]
    public class AracPlakalar : BaseEntity
    {
        [Key]
        public int PlakaId { get; set; }

        [Required]
        [StringLength(10)]
        public string Plaka { get; set; }

        [StringLength(50)]
        public string? Aciklama { get; set; }
    }
}
