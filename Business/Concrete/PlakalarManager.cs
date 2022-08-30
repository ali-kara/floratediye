using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PlakalarManager : IPlakalarService
    {
        IPlakalarDAL plakalarDAL;

        public PlakalarManager(IPlakalarDAL plakalarDAL)
        {
            this.plakalarDAL = plakalarDAL;
        }

        public List<AracPlakalar> PlakalarList()
        {
            List<AracPlakalar> list = plakalarDAL.GetList();

            return list;
        }
    }
}
