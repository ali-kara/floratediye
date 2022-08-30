using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efNakliyeTombalaDAL : EfEntityRepositoryBase<NakliyeTombala, MainDBContext>, INakliyeTombalaDAL
    {

    }
}
