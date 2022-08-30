using Business.Abstract;
using DataAccess.NBS.Abstract;
using Entities.Log.Concrete;
using Entities.Log.DTO;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDAL locationDAL;

        public LocationManager(ILocationDAL locationDAL)
        {
            this.locationDAL = locationDAL;
        }

        public List<Location> GetLocationsByUserCode(string Sofor_Kodu)
        {
            var list = locationDAL.GetList(x => x.SoforKodu == Sofor_Kodu);
            return list;

        }

        public Location InsertLocation(LocationInsertDTO locationInsert)
        {
            //TODO: İmplememnt AutoMapper

            var location = new Location
            {
                latitude = locationInsert.latitude,
                longitude = locationInsert.longitude,
                SoforKodu = locationInsert.Sofor_Kodu,
            };

            locationDAL.Insert(location);

            return location;
        }
    }
}
