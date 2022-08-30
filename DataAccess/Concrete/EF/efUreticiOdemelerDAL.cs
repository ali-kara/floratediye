using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efUreticiOdemelerDAL : EfEntityRepositoryBase<URETICI_ODEMELER2, MainDBContext>, IUreticiOdemelerDAL
    {

    }
}
