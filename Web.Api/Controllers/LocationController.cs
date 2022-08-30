using Business.Abstract;
using Core.Utilities.Results;
using Entities.Log.Concrete;
using Entities.Log.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        [HttpGet("getLocation")]
        public IActionResult GetLocation(string soforKodu)
        {
            ListDataResult<Location> response = new ListDataResult<Location>();

            try
            {
                var list = locationService.GetLocationsByUserCode(soforKodu);
                response.Data = list;
            }
            catch
            {
                return Ok(new ErrorResult($"{soforKodu} ait konum bilgisi getirelemiyor."));

            }

            return Ok(response);

        }


        [HttpPost("insert")]
        public IActionResult Insert(LocationInsertDTO locationInsert)
        {
            var response = new DataResult<Location>();

            try
            {
                var ins = new Location();


                decimal lat, lon;

                if (decimal.TryParse(locationInsert.latitude.ToString(), out lat))
                {
                    ins.latitude = lat;
                }

                if (decimal.TryParse(locationInsert.longitude.ToString(), out lon))
                {
                    ins.longitude = lon;
                }

                response.Data = locationService.InsertLocation(locationInsert);

            }
            catch (Exception ex)
            {
                return Ok(new ErrorResult(ex.Message));
            }

            return Ok(response);

        }
    }
}