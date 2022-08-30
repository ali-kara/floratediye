using Entities.Log.Concrete;
using Entities.Log.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        Location InsertLocation(LocationInsertDTO locationInsert);
        List<Location> GetLocationsByUserCode(string Sofor_Kodu);
    }
}