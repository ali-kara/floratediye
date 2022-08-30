using Entities.Log.Concrete;
using Entities.Log.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppVersionService
    {
        public AppVersion GetAppVersion(DevicePlatform devicePlatform, string appVersion);

    }
}
