using Business.Abstract;
using DataAccess.Log.Abstract;
using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.DTO;

namespace Business.Concrete
{
    public class DuyurularManager : IDuyurularService
    {
        IDuyurularDAL duyurularDAL;

        public DuyurularManager(IDuyurularDAL duyurularDAL)
        {
            this.duyurularDAL = duyurularDAL;
        }

        public DuyurularDTO DuyuruGetir(int id)
        {
            return null;
        }

        public List<DuyurularDTO> DuyurulariGetir()
        {
            List<Duyurular> list = duyurularDAL.GetList(x => x.IsExpired == false
          && (x.BitisTarihi.HasValue == false
          || x.BitisTarihi.Value.Date <=
         DateTime.Now.Date)
          ).ToList();

            return null;
        }

        public List<Duyurular> DuyurularimiGetir(URETICILER uretici)
        {
            ////List<Duyurular> list = GetList(x => x.IsExpired == false
            ////&& (x.BitisTarihi.HasValue == false
            ////|| DbFunctions.TruncateTime(x.BitisTarihi) <=
            ////DbFunctions.TruncateTime(DateTime.Now))
            ////).ToList();

            //DateTime bugun = DateTime.Now.Date;

            //List<Duyurular> onayGerekmez = (
            //    from D in context.Duyurular
            //    where
            //    D.IsExpired == false &&
            //    D.Pasif != true &&
            //    D.OnayGerekir == false &&
            //    D.BitisTarihi >= bugun &&
            //    (
            //        (D.HerkeseMi == true)
            //        ||
            //        (D.HerkeseMi == false && D.Bolge == uretici.IL)
            //    )
            //    select D).ToList();

            //List<Duyurular> onayGerekir = (
            //    from D in context.Duyurular
            //    where
            //    D.IsExpired == false &&
            //    D.Pasif != true &&
            //    D.OnayGerekir == true &&
            //    (
            //    (D.HerkeseMi == true)
            //    ||
            //    (D.HerkeseMi == false && D.Bolge == uretici.IL)
            //    )
            //    select D).ToList();

            //List<Duyurular> onaylanmayan = onayGerekir.ToList();

            //foreach (Duyurular item in onayGerekir)
            //{
            //    DuyurularKayit dk = context.DuyurularKayit.Where(x => x.DuyuruID == item.DuyuruID && x.UreticiNo == uretici.URETICI_NO && x.Onaylandi == true).FirstOrDefault();

            //    if (dk != null)
            //    {
            //        onaylanmayan.Remove(item);
            //    }
            //}

            //return onayGerekmez.Concat(onaylanmayan).ToList();

            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            Duyurular duyurular = duyurularDAL.Get(x => x.DuyuruID == id);

            duyurular.Pasif = true;

            duyurularDAL.Update(duyurular);

            return true;
        }

        public List<UreticiDuyurularimDTO> TumDuyurularimiGetir(URETICILER uretici)
        {
            //List<vmUreticiDuyurularim> list = (
            //               from DK in context.DuyurularKayit
            //               join D in context.Duyurular
            //               on DK.DuyuruID equals D.DuyuruID
            //               where
            //              (
            //              D.Pasif != true
            //              &&

            //               (D.HerkeseMi == true)
            //               ||
            //               (D.HerkeseMi == false && D.Bolge == uretici.IL)
            //               )
            //               select new vmUreticiDuyurularim
            //               {
            //                   Baslik = D.Baslik,
            //                   Mesaj = D.Mesaj,
            //                   DuyuruTarihi = D.OlusturmaTarihi.Value,
            //                   OnayTarihi = DK.OlusturmaTarihi
            //               }).ToList();



            //return list;

            return null;
        }
    }
}
