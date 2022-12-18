using System;
using Core.Entities.Abstract;
using Microsoft.AspNetCore.Http;

namespace Core.Web.Utilities
{
    public class SessionManager : IWebSessionManager
    {
        public static void Clear()
        {
            _session = _httpContextAccessor.HttpContext?.Session;
            if (_session != null)
            {
                _session.Clear();

            }
        }

        public static object? Get(object key)
        {
            throw new NotImplementedException();
        }

        public static T? Get<T>(object key)
        {
            throw new NotImplementedException();
        }

        public static void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public static void Set(object key, object obj)
        {
            throw new NotImplementedException();
        }

        public static void Set<T>(object key, T obj) where T : IEntity
        {
            throw new NotImplementedException();
        }

        public static void SetHttpContextAccessor(IHttpContextAccessor accessor)
        {
            throw new NotImplementedException();
        }
    }
}

