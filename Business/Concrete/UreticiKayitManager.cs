using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UreticiKayitManager : IUreticiKayitService
    {
        IUreticiKayitDAL ureticiKayitDAL;

        public UreticiKayitManager(IUreticiKayitDAL ureticiKayitDAL)
        {
            this.ureticiKayitDAL = ureticiKayitDAL;
        }

        public List<ur_toplam> Getir(int URETICI_ID, DateTime dateBaslangic, DateTime dateBitis)
        {
            List<ur_toplam> list = new List<ur_toplam>();

            list = ureticiKayitDAL.GetList(x => x.ur_no == URETICI_ID.ToString() && x.tarih >= dateBaslangic.Date && x.tarih <= dateBitis.Date).OrderBy(x => x.tarih).ToList();

            return list;
        }
    }
}
