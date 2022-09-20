using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.DTO;

namespace Business.Abstract
{
    public interface IDuyurularService
    {
        Duyurular DuyuruGetir(int id);
        List<DuyurularDTO> DuyurulariGetir();
        bool Sil(int id);
        List<Duyurular> DuyurularimiGetir(int UreticiID);
        List<Duyurular> DuyurularimiGetir(URETICILER Uretici);
    }
}
