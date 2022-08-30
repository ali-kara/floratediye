using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NakliyeTombalaManager : INakliyeTombalaService
    {
        INakliyeTombalaDAL nakliyeTombalaDAL;

        public NakliyeTombalaManager(INakliyeTombalaDAL nakliyeTombalaDAL)
        {
            this.nakliyeTombalaDAL = nakliyeTombalaDAL;
        }

        public List<NakliyeTombala> TombalaGetir(string SoforKodu, string Bolge, string Plaka)
        {
            var list = nakliyeTombalaDAL.GetList(x => x.SoforKodu == SoforKodu
            && x.Bolge == Bolge
            && x.Plaka == Plaka
            && x.Pasif != true
            && x.OlusturmaTarihi.Value.Date == DateTime.Now.Date)
                .OrderByDescending(x => x.OlusturmaTarihi).ToList();

            // TODO : Test

            return list;
        }

        public bool TombalaKaydet(NakliyeTombala nakliyeTombala)
        {
            nakliyeTombalaDAL.Insert(nakliyeTombala);
            return true;
        }

        public bool TombalaSil(int id)
        {
            NakliyeTombala nakliye = nakliyeTombalaDAL.Get(x => x.Id == id);
            nakliye.Pasif = true;
            nakliye.GuncellemeTarihi = DateTime.Now;

            nakliyeTombalaDAL.Update(nakliye);

            return true;
        }
    }
}
