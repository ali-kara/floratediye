using Business.Abstract;
using DataAccess.Log.Abstract;
using Entities.Log.Concrete;

namespace Business.Concrete
{
    public class DuyurularKayitManager : IDuyurularKayitService
    {
        IDuyurularKayitDAL duyurularKayitDAL;
        IDuyurularDAL duyuruDAL;

        public DuyurularKayitManager(IDuyurularKayitDAL duyurularKayitDAL, IDuyurularDAL duyuruDAL)
        {
            this.duyurularKayitDAL = duyurularKayitDAL;
            this.duyuruDAL = duyuruDAL;
        }

        public bool DuyuruOnayla(string UreticiNo, int DuyuruID)
        {
            Duyurular d = duyuruDAL.Get(x => x.DuyuruID == DuyuruID);

            duyurularKayitDAL.Insert(new DuyurularKayit
            {
                DuyuruID = DuyuruID,
                UreticiNo = UreticiNo,
                Onaylandi = true,
                SonGuncelleyen = UreticiNo,
                Baslik = d.Baslik,
                Mesaj = d.Mesaj
            });

            return true;
        }
    }
}
