using System;
using Core.Web.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Services
{
    public class AuthManager : SessionManager
    {
        public static bool IsAuthenticated()
        {
            if (Get(SessionKeys.Uretici) == null)
            {
                return false;
            }

            return true;
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