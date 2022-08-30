using Business.Abstract;
using DataAccess.NBS.Abstract;
using Entities.Log.Concrete;
using Entities.Log.Enums;

namespace Business.Concrete
{
    public class AppVersionManager : IAppVersionService
    {

        IAppVersionDAL versionDAL;

        public AppVersionManager(IAppVersionDAL versionDAL)
        {
            this.versionDAL = versionDAL;
        }

        public AppVersion GetAppVersion(DevicePlatform devicePlatform, string appVersion)
        {
            return versionDAL.Get(x=>x.Platform == devicePlatform && Version.Parse(x.Version) == Version.Parse(appVersion));
        }
    }
}
