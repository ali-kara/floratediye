using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using Entities.Log.Concrete;
using Entities.Log.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoforlerController : ControllerBase
    {
        readonly ISoforlerService soforlerService;

        readonly IDuyurularService duyurularService;

        public SoforlerController(ISoforlerService soforlerService, IDuyurularService duyurularService)
        {
            this.soforlerService = soforlerService;
            this.duyurularService = duyurularService;
        }

        [HttpGet("getall")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = new ListDataResult<DuyurularDTO>();

            try
            {
                //List<Soforler> list = soforlerService.GetAllDrivers();

                var list = duyurularService.DuyurulariGetir();


                response.Data = list;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }


            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(SoforLoginDTO soforLoginDTO)
        {
            var response = new DataResult<Soforler>();

            try
            {
                Soforler sofor = soforlerService.Login(soforLoginDTO.UserName, soforLoginDTO.Password);


                if (sofor == null)
                {
                    response.Message = "Böyle bir şoför yok";
                    response.Success = false;
                }
                else
                {
                    response.Data = sofor;
                }


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
