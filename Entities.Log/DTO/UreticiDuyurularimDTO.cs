using Entities.Log.Abstract;
using System.ComponentModel;

namespace Entities.Log.DTO
{
    public class UreticiDuyurularimDTO : BaseDTO
    {
        [DisplayName("Başlık")]
        public string Baslik { get; set; }
        [DisplayName("Mesaj")]
        public string Mesaj { get; set; }
        [DisplayName("Duyuru Tarihi")]
        public DateTime DuyuruTarihi { get; set; }
        [DisplayName("Onay Tarihi")]
        public DateTime? OnayTarihi { get; set; }
    }

}
