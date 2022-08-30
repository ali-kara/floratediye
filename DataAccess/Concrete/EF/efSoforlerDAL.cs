using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efSoforlerDAL : EfEntityRepositoryBase<Soforler, MainDBContext>, ISoforlerDAL
    {

    }
}
