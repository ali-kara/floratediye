using Business.Abstract;
using Core.Utilities.Results;
using Entities.Log.Concrete;
using Entities.Log.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        IAppVersionService versionService;

        public VersionController(IAppVersionService versionService)
        {
            this.versionService = versionService;
        }

        
        [HttpGet("getAppVersion")]
        public IActionResult GetAppVersion(string appVersion, DevicePlatform platform)
        {
            var result = new DataResult<AppVersion>();

            if (!Version.TryParse(appVersion, out var v))
            {
                return Ok(new ErrorResult("Version Format Error"));
            }

            result.Data = versionService.GetAppVersion(platform, appVersion);

            if (Version.Parse(result.Data.Version) > Version.Parse(appVersion))
            {
                result.Message = "There is new app avalible on your device!!";
            }

            return Ok(result);

        }
    }




}
