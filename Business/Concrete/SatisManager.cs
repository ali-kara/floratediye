using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SatisManager : ISatisService
    {

        ISatisDAL satisDAL;

        public SatisManager(ISatisDAL satisDAL)
        {
            this.satisDAL = satisDAL;
        }

        public List<satis> GetDetailList(int URETICI_ID, string sube, DateTime? tarih, int satis_sira_no)
        {
            List<satis> list = satisDAL.GetList(x => x.sube == sube && x.tarih == tarih && x.uretici_kodu == URETICI_ID.ToString() && x.sira_no == satis_sira_no);

            return list;
        }
    }
}

