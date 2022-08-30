using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISoforlerService
    {
        Soforler GetDriver(string Kodu);
        Soforler Login(string Kodu, string Parola);
        List<Soforler> GetAllDrivers();

    }
}
