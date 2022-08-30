using Core.Entities.Abstract;

namespace Entities.DTO
{
    public class TombalaGetDTO : IDto
    {
        public string? Sofor_Kodu { get; set; }
        public string? Bolge { get; set; }
        public string? Plaka { get; set; }

    }
}
