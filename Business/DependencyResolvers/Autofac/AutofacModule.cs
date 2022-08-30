using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using DataAccess.Log.Abstract;
using DataAccess.Log.Concrete.EF;
using DataAccess.NBS.Abstract;
using DataAccess.NBS.Concrete.EF;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<BolgelerManager>().As<IBolgelerService>().SingleInstance();
            builder.RegisterType<efBolgelerDAL>().As<IBolgelerDAL>().SingleInstance();

            builder.RegisterType<DuyurularKayitManager>().As<IDuyurularKayitService>().SingleInstance();
            builder.RegisterType<efDuyurularKayitDAL>().As<IDuyurularKayitDAL>().SingleInstance();

            builder.RegisterType<DuyurularManager>().As<IDuyurularService>().SingleInstance();
            builder.RegisterType<efDuyurularDAL>().As<IDuyurularDAL>().SingleInstance();

            builder.RegisterType<LocationManager>().As<ILocationService>().SingleInstance();
            builder.RegisterType<efLocationDAL>().As<ILocationDAL>().SingleInstance();

            builder.RegisterType<NakliyeTombalaManager>().As<INakliyeTombalaService>().SingleInstance();
            builder.RegisterType<efNakliyeTombalaDAL>().As<INakliyeTombalaDAL>().SingleInstance();

            builder.RegisterType<PlakalarManager>().As<IPlakalarService>().SingleInstance();
            builder.RegisterType<efPlakalarDAL>().As<IPlakalarDAL>().SingleInstance();

            builder.RegisterType<RekolteManager>().As<IRekolteService>().SingleInstance();
            builder.RegisterType<efBolgelerDAL>().As<IBolgelerDAL>().SingleInstance();

            builder.RegisterType<SoforlerManager>().As<ISoforlerService>().SingleInstance();
            builder.RegisterType<efSoforlerDAL>().As<ISoforlerDAL>().SingleInstance();

            builder.RegisterType<SubeSatisManager>().As<ISubeSatisService>().SingleInstance();
            builder.RegisterType<efSubeSatisDAL>().As<ISubeSatisDAL>().SingleInstance();

            builder.RegisterType<UreticiKayitManager>().As<IUreticiKayitService>().SingleInstance();
            builder.RegisterType<efUreticiKayitDAL>().As<IUreticiKayitDAL>().SingleInstance();

            builder.RegisterType<UreticilerManager>().As<IUreticilerService>().SingleInstance();
            builder.RegisterType<efUreticilerDAL>().As<IUreticilerDAL>().SingleInstance();

            builder.RegisterType<UreticiOdemelerManager>().As<IUreticiOdemelerService>().SingleInstance();
            builder.RegisterType<efUreticiOdemelerDAL>().As<IUreticiOdemelerDAL>().SingleInstance();

            builder.RegisterType<WebExceptionManager>().As<IWebExceptionService>().SingleInstance();
            builder.RegisterType<efWebExceptionDAL>().As<IWebExceptionDAL>().SingleInstance();

            builder.RegisterType<AppVersionManager>().As<IAppVersionService>().SingleInstance();
            builder.RegisterType<efAppVersionDAL>().As<IAppVersionDAL>().SingleInstance();

        }
    }
}