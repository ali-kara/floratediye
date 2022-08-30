using Business.Abstract;
using DataAccess.Log.Abstract;
using Entities.Log.Concrete;

namespace Business.Concrete
{
    public class WebExceptionManager : IWebExceptionService
    {
        IWebExceptionDAL webExceptionDAL;
        public WebExceptionManager(IWebExceptionDAL webExceptionDAL)
        {
            this.webExceptionDAL = webExceptionDAL;
        }

        public List<WebExceptionLogs> GetAllExceptions()
        {
            List<WebExceptionLogs> list = webExceptionDAL.GetIEnum().OrderByDescending(x => x.OlusturmaTarihi).ToList();
            return list;
        }

    }
}
