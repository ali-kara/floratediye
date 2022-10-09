using System;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISatisService
    {
        List<satis> GetDetailList(int URETICI_ID, string sube, DateTime? tarih, int satis_sira_no);
    }
}

