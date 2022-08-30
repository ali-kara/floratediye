using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SubeSatisManager : ISubeSatisService
    {
        ISubeSatisDAL satisDAL;

        public SubeSatisManager(ISubeSatisDAL satisDAL)
        {
            this.satisDAL = satisDAL;
        }

        public List<SubeSatis> GetAll()
        {
            List<SubeSatis> list = satisDAL.GetList();
            return list;
        }
    }
}
