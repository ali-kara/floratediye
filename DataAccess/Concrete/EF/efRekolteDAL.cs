using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efRekolteDAL : EfEntityRepositoryBase<rekolte, MainDBContext>, IRekolteDAL
    {

    }
}
