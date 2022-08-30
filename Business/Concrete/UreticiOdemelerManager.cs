using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UreticiOdemelerManager : IUreticiOdemelerService
    {
        IUreticiOdemelerDAL ureticiOdemelerDAL;

        public UreticiOdemelerManager(IUreticiOdemelerDAL ureticiOdemelerDAL)
        {
            this.ureticiOdemelerDAL = ureticiOdemelerDAL;
        }

        public List<URETICI_ODEMELER2> UreticiOdemeGetir(int URETICI_ID)
        {
            List<URETICI_ODEMELER2> list = ureticiOdemelerDAL.GetIEnum(x => x.URETICI_ID == URETICI_ID).OrderByDescending(x => x.URETICI_ODEME_ID).ToList();
            return list;
        }
    }
}
