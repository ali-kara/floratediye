using Core.Entities.Abstract;

namespace Entities.DTO
{
    public class SoforLoginDTO : IDto
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
