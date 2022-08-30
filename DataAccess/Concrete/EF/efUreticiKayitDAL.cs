using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efUreticiKayitDAL : EfEntityRepositoryBase<ur_toplam, MainDBContext>, IUreticiKayitDAL
    {

    }
}
