using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EF
{
    public class efSatisDAL : EfEntityRepositoryBase<satis, MainDBContext>, ISatisDAL
    {

    }
}

