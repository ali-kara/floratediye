using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GirisController : ControllerBase
    {
        IPlakalarService plakalarService;
        IBolgelerService bolgelerService;

        public GirisController(IPlakalarService plakalarService,IBolgelerService bolgelerService)
        {
            this.plakalarService = plakalarService;
            this.bolgelerService = bolgelerService;
        }

        [HttpGet("plakagetir")]
        public IActionResult PlakaGet()
        {
            var response = new ListDataResult<AracPlakalar>();

            try
            {
                var list = plakalarService.PlakalarList();

                response.Data = list;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }


            return Ok(response);


        }

        [HttpGet("bolgegetir")]
        public IActionResult BolgeGet()
        {
            var response = new ListDataResult<Bolgeler>();

            try
            {
                var list = bolgelerService.BolgelerList();

                response.Data = list;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }


            return Ok(response);
        }
    }
}
