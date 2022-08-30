using Core.DataAccess.EntityFramework;
using DataAccess.Log.Abstract;
using Entities.Log.Concrete;

namespace DataAccess.Log.Concrete.EF
{
    public class efDuyurularKayitDAL : EfEntityRepositoryBase<DuyurularKayit, LogDBContext>, IDuyurularKayitDAL
    {

    }
}
