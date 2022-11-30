using Entities.Concrete;
using Entities.Log.Concrete;

namespace Business.Abstract
{
    public interface IUreticilerService
    {
        List<URETICILER> UreticileriSehreGoreGetir(string Sehir);
        List<Country> UreticiSehirleriGetir();

        URETICILER Login(string ureticiNo, string Parola);
        URETICILER LoginByUserName(string ureticiNo);

        URETICILER GetById(string URETICI_NO);

    }
}
