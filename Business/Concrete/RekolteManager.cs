using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RekolteManager : IRekolteService
    {
        IRekolteDAL rekolteDAL;

        public RekolteManager(IRekolteDAL rekolteDAL)
        {
            this.rekolteDAL = rekolteDAL;
        }

        public bool RekolteVarmi(int UreticiID)
        {
            List<rekolte> list = rekolteDAL.GetList(x => x.ur_no == UreticiID && x.sezon == DateTime.Now.Year.ToString()).ToList();

            if (list != null && list.Count != 0)
            {
                return true;
            }

            return false;
        }
    }
}
