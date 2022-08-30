using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efUreticilerDAL : EfEntityRepositoryBase<URETICILER, MainDBContext>, IUreticilerDAL
    {

    }
}
