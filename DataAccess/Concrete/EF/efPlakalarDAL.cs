using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efPlakalarDAL : EfEntityRepositoryBase<AracPlakalar, MainDBContext>, IPlakalarDAL
    {

    }
}
