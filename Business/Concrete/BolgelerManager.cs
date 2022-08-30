using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BolgelerManager : IBolgelerService
    {
        IBolgelerDAL bolgelerDAL;

        public BolgelerManager(IBolgelerDAL bolgelerDAL)
        {
            this.bolgelerDAL = bolgelerDAL;
        }

        public List<Bolgeler> BolgelerList()
        {
            List<Bolgeler> list = bolgelerDAL.GetList();

            return list;
        }
    }
}
