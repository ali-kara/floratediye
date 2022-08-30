using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace Core.Entities
{
	[DebuggerStepThrough]
	public class BaseEntity : IEntity
	{
		[JsonIgnore]
		public bool? Pasif { get; set; } = false;

		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
		[JsonIgnore]
		public DateTime? OlusturmaTarihi { get; set; } = DateTime.Now;

		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
		[JsonIgnore]
		public DateTime? GuncellemeTarihi { get; set; }

		[StringLength(20)]
		[JsonIgnore]
		public string? SonGuncelleyen { get; set; }
	}
}
