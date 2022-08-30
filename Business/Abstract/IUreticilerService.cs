using Entities.Concrete;
using Entities.Log.Concrete;

namespace Business.Abstract
{
    public interface IUreticilerService
    {
        List<URETICILER> UreticileriSehreGoreGetir(string Sehir);
        List<Country> UreticiSehirleriGetir();

        URETICILER Login(string URETICI_NO, string Parola);
        URETICILER GetById(string URETICI_NO);

    }
}
