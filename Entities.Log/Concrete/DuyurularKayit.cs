using Core.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Log.Concrete
{
	[Table("DuyurularKayit")]
	public class DuyurularKayit : BaseEntity
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[DisplayName("Numara")]
		[Key]
		public int KayitId { get; set; }
		public string UreticiNo { get; set; }
		
		[DisplayName("Onaylandı")]
		public bool Onaylandi { get; set; } = false;
		
		[DisplayName("Başlık")]
		[Required]
		public string Baslik { get; set; }

		[DisplayName("Mesaj")]
		[DataType(DataType.MultilineText)]
		[Required]
		public string Mesaj { get; set; }


		public int DuyuruID { get; set; }
		public virtual Duyurular Duyurular { get; set; }
	}
}
