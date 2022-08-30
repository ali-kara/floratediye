using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INakliyeTombalaService
    {
        bool TombalaSil(int id);
        bool TombalaKaydet(NakliyeTombala nakliyeTombala);
        List<NakliyeTombala> TombalaGetir(string SoforKodu, string Bolge, string Plaka);
    }
}
