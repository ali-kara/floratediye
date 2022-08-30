using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efBolgelerDAL : EfEntityRepositoryBase<Bolgeler, MainDBContext>, IBolgelerDAL
    {

    }
}
