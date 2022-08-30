using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SoforlerManager : ISoforlerService
    {
        ISoforlerDAL soforlerDAL;

        public SoforlerManager(ISoforlerDAL soforlerDAL)
        {
            this.soforlerDAL = soforlerDAL;
        }

        public List<Soforler> GetAllDrivers()
        {
            var list = soforlerDAL.GetList();
            return list;
        }

        public Soforler GetDriver(string Kodu)
        {
            var sofor = soforlerDAL.Get(x => x.Kodu == Kodu);
            return sofor;
        }

        public Soforler Login(string Kodu, string Parola)
        {
            var sofor = soforlerDAL.Get(x => x.Kodu == Kodu && x.Parola == Parola);
            return sofor;
        }
    }
}
