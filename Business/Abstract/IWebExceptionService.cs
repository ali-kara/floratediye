using Entities.Log.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWebExceptionService
    {
        List<WebExceptionLogs> GetAllExceptions();
    }
}
