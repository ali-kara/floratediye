using Core.DataAccess.EntityFramework;
using DataAccess.Log.Abstract;
using Entities.Log.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Log.Concrete.EF
{
    public class efWebExceptionDAL : EfEntityRepositoryBase<WebExceptionLogs, LogDBContext>, IWebExceptionDAL
    {
    }
}
