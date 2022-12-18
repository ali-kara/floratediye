using System;
using Core.Entities.Abstract;
using Microsoft.AspNetCore.Http;

namespace Core.Web.Utilities
{
    public interface IWebSessionManager
    {
        public static IHttpContextAccessor _httpContextAccessor;
        public static ISession _session;

        abstract static void SetHttpContextAccessor(IHttpContextAccessor accessor);
        abstract static void Set(object key, object obj);
        abstract static void Set<T>(object key, T obj) where T : IEntity;
        abstract static object? Get(object key);
        abstract static T? Get<T>(object key);
        abstract static void Remove(object key);
        abstract static void Clear();
    }
}

