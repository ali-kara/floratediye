using Core.DataAccess;
using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.DTO;

namespace DataAccess.Log.Abstract
{
    public interface IDuyurularDAL : IEntityRepository<Duyurular>
    {
        List<UreticiDuyurularimDTO> TumDuyurularimiGetir(URETICILER uretici);
    }
}
