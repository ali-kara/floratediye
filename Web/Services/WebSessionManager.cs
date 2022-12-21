using System.Text;
using Core.Entities.Abstract;
using Core.Utilities.Results;
using Core.Web.Utilities;
using Entities.Concrete;
using Entities.Log.Enums;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Web.Services
{
    //public abstract class WebSessionManager : IWebSessionManager
    //{

    //    public static string FilterDate_Start
    //    {
    //        get
    //        {
    //            var date = Get(SessionKeys.FilterDate_Start);
    //            return Convert.ToDateTime(date).Date.ToString("dd.MM.yyyy");
    //        }
    //    }
    //    public static string FilterDate_End
    //    {
    //        get
    //        {
    //            var date = Get(SessionKeys.FilterDate_End);
    //            return Convert.ToDateTime(date).Date.ToString("dd.MM.yyyy");
    //        }
    //    }
    //    public static URETICILER Uretici
    //    {
    //        get
    //        {
    //            return Get<URETICILER>(SessionKeys.Uretici);
    //        }
    //    }


    //    private static IHttpContextAccessor _httpContextAccessor;
    //    private static ISession _session;

    //    public static void SetHttpContextAccessor(IHttpContextAccessor accessor)
    //    {
    //        _httpContextAccessor = accessor;
    //    }
    //    public static void Set(object key, object obj)
    //    {
    //        _session = _httpContextAccessor.HttpContext?.Session;

    //        _session?.SetString(key.ToString(), obj.ToString());
    //    }
    //    public static void Set<T>(object key, T obj) where T : IEntity
    //    {
    //        _session = _httpContextAccessor.HttpContext?.Session;


    //        if (_session != null)
    //        {
    //            var str = JsonConvert.SerializeObject(obj);
    //            _session.SetString(key.ToString(), str.ToString());
    //        }
    //    }
    //    public static object? Get(object key)
    //    {
    //        _session = _httpContextAccessor.HttpContext?.Session;

    //        var obj = _session?.GetString(key.ToString());

    //        //if (obj != null)
    //        //{
    //        //    return _session?.Get(key.ToString());
    //        //}

    //        return obj.ToString();
    //    }
    //    public static T? Get<T>(object key)
    //    {
    //        _session = _httpContextAccessor.HttpContext?.Session;

    //        var obj = _session?.Get(key.ToString());
    //        var str = Encoding.Default.GetString(obj);


    //        if (obj != null)
    //        {
    //            var TObject = JsonConvert.DeserializeObject<T>(str);

    //            return TObject;
    //        }

    //        return default(T);
    //    }
    //    public static void Remove(object key)
    //    {
    //        _session = _httpContextAccessor.HttpContext?.Session;

    //        _session.Remove(key.ToString());
    //    }
    //    public static void Clear()
    //    {
    //        _session = _httpContextAccessor.HttpContext?.Session;
    //        if (_session != null)
    //        {
    //            _session.Clear();

    //        }
    //    }
    //}


    public class WebSessionManager2 : SessionManager
    {
        public static string FilterDate_Start
        {
            get
            {
                var date = Get(SessionKeys.FilterDate_Start);
                return Convert.ToDateTime(date).Date.ToString("dd.MM.yyyy");
            }
        }
        public static string FilterDate_End
        {
            get
            {
                var date = Get(SessionKeys.FilterDate_End);
                return Convert.ToDateTime(date).Date.ToString("dd.MM.yyyy");
            }
        }
        public static URETICILER Uretici
        {
            get
            {
                return Get<URETICILER>(SessionKeys.Uretici);
            }
        }

    }
}