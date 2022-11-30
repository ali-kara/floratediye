using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Log.Concrete;

namespace Business.Concrete
{
    public class UreticilerManager : IUreticilerService
    {
        IUreticilerDAL ureticilerDAL;
        public UreticilerManager(IUreticilerDAL ureticilerDAL)
        {
            this.ureticilerDAL = ureticilerDAL;
        }


        public URETICILER GetById(string URETICI_NO)
        {
            URETICILER uretici = ureticilerDAL.Get(x => x.URETICI_NO == URETICI_NO);

            return uretici;
        }

        public URETICILER Login(string UreticiNo, string Parola)
        {
            URETICILER uretici = ureticilerDAL.Get(x => x.URETICI_NO == UreticiNo && x.Parola == Parola);
            return uretici;
        }

        public URETICILER LoginByUserName(string UreticiNo)
        {
            URETICILER u = ureticilerDAL.Get(x => x.URETICI_NO == UreticiNo);
            return u;
        }

        public List<URETICILER> UreticileriSehreGoreGetir(string Sehir)
        {
            List<URETICILER> list = ureticilerDAL.GetList(x => x.IL == Sehir);

            return list;
        }

        public List<Country> UreticiSehirleriGetir()
        {
            List<Country> list = ureticilerDAL.GetIEnum().GroupBy(x => x.IL)
                .Select(x =>
                new Country
                {
                    CountryName = x.Key.ToString()
                })
                .ToList();

            list = list.Where(x => !string.IsNullOrWhiteSpace(x.CountryName))
                .Distinct()
                .ToList();

            return list;
        }
    }
}
