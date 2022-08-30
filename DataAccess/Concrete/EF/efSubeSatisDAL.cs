using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efSubeSatisDAL : EfEntityRepositoryBase<SubeSatis, MainDBContext>, ISubeSatisDAL
    {

    }
}
