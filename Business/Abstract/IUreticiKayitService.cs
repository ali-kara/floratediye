using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUreticiKayitService
    {
        List<ur_toplam> Getir(int URETICI_ID, DateTime dateBaslangic, DateTime dateBitis);
    }
}
