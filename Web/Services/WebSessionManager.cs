using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Services
{
    public class WebSessionManager
    {

        public static string FilterDate_Start
        {
            get
            {
                var date = Get(SessionKeys.FilterDate_Start);


                DateTime d = Convert.ToDateTime(date);

                return d.Date.ToString("dd.MM.yyyy");
                //return string.Format("{0:dd.MM.yyyy}", date.ToString());
            }
        }

        public static DateTime FilterDate_End
        {
            get
            {
                DateTime date = (DateTime)Get(SessionKeys.FilterDate_End);

                // Normal görüntülemede kontrol amaçlı idi ama gecmiş kayıtlar problem çıkardı.
                //if (date.Year != DateTime.Now.Year)
                //{
                //    date = DateTime.Now;
                //}

                return date;
            }
        }






        private static IHttpContextAccessor _httpContextAccessor;
        private static ISession _session;

        public static void SetHttpContextAccessor(IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
        }

        public static void Set(SessionKeys key, object obj)
        {
            _session = _httpContextAccessor.HttpContext?.Session;

            _session?.SetString(key.ToString(), obj.ToString());
        }

        //public static void Set<T>(SessionKeys key, T obj)
        //{
        //    _session = _httpContextAccessor.HttpContext?.Session;


        //    if (_session != null)
        //    {
        //        var str = JsonConvert.SerializeObject(obj);
        //        _session.SetString(key.ToString(), str);
        //    }
        //}

        public static object? Get(SessionKeys key)
        {
            _session = _httpContextAccessor.HttpContext?.Session;

            var obj = _session?.GetString(key.ToString());

            //if (obj != null)
            //{
            //    return _session?.Get(key.ToString());
            //}

            return obj.ToString();
        }

        public static T? Get<T>(SessionKeys key)
        {
            _session = _httpContextAccessor.HttpContext?.Session;

            var obj = _session?.Get(key.ToString());

            if (obj != null)
            {
                var TObject = JsonConvert.DeserializeObject<T>(key.ToString());

                return TObject;
            }

            return default(T);
        }

        public static void Remove(SessionKeys key)
        {
            _session = _httpContextAccessor.HttpContext?.Session;

            _session?.Remove(key.ToString());
        }

        public static void Clear()
        {
            _session = _httpContextAccessor.HttpContext?.Session;

            _session?.Clear();
        }
    }
}

