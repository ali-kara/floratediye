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

