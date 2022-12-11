using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Services
{
    public class AuthManager
    {

        private static IHttpContextAccessor httpContextAccessor;

        public static void SetHttpContextAccessor(IHttpContextAccessor accessor)
        {
            httpContextAccessor = accessor;
        }


        public static string GetDate()
        {
            var HttpContext = httpContextAccessor.HttpContext;

            var date = HttpContext.Session.GetString(SessionKeys.FilterDate_Start.ToString());


            // Normal görüntülemede kontrol amaçlı idi ama gecmiş kayıtlar problem çıkardı.
            //if (date.Year != DateTime.Now.Year)
            //{
            //    date = DateTime.Now;
            //}

            return string.Format("{0:dd.MM.yyyy}", date.ToString());
        }

    

        public static bool IsAuthenticated()
        {
            var HttpContext = httpContextAccessor.HttpContext;


            if (HttpContext.Session.GetString(@SessionKeys.Kullanici.ToString()) == null)
            {
                return false;
            }

            return true;

        }
    }
}

