using Core.DataAccess.EntityFramework;
using DataAccess.Log.Abstract;
using Entities.Concrete;
using Entities.Log.Concrete;
using Entities.Log.DTO;

namespace DataAccess.Log.Concrete.EF
{
    public class efDuyurularDAL : EfEntityRepositoryBase<Duyurular, LogDBContext>, IDuyurularDAL
    {
        public List<UreticiDuyurularimDTO> TumDuyurularimiGetir(URETICILER uretici)
        {
            //List<vmUreticiDuyurularim> list = (
            //               from DK in context.
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
