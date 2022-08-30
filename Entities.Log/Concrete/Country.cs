using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entities.Log.Concrete
{
    [Table("Countries")]
    public class Country : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("İl No")]
        [Key]
        public int CountryID { get; set; }

        [DisplayName("İl Adı")]
        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }

        public virtual List<Sube> subeler { get; set; }
    }
}