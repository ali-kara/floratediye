﻿using Core.DataAccess.EntityFramework;
using DataAccess.NBS.Abstract;
using Entities.Log.Concrete;

namespace DataAccess.NBS.Concrete.EF
{
    public class efLocationDAL : EfEntityRepositoryBase<Location, NBSDBContext>, ILocationDAL
    {

    }
}
