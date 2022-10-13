using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTradeSystem.DataAccess.Concrete
{
    public class MockingClas
    {

        public void Deneme(int a, int b)
        {
            if (a == 0)
                throw new Exception("A değeri 0 olamaz");
        }
    }


    public class DenemeClass
    {
        public DenemeClass()
        {
            MockingClas mockingClas = new MockingClas();

            try
            {
                mockingClas.Deneme(2, 5);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
