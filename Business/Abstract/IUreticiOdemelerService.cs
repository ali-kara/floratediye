using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUreticiOdemelerService
    {
        List<URETICI_ODEMELER2> UreticiOdemeGetir(int URETICI_ID);
    }
}
