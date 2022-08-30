using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.DTO;

namespace Business.Abstract
{
    public interface IDuyurularService
    {
        DuyurularDTO DuyuruGetir(int id);
        List<DuyurularDTO> DuyurulariGetir();
        bool Sil(int id);
        List<Duyurular> DuyurularimiGetir(URETICILER uretici);
        List<UreticiDuyurularimDTO> TumDuyurularimiGetir(URETICILER uretici);
    }
}
