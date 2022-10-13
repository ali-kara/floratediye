using System;
using System.Diagnostics.CodeAnalysis;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Web.Tools
{

    public enum SessionKeys
    {
        UreticiId,
        Uretici,
        Kullanici,
        FilterDate_Start,
        FilterDate_End,
        UreticiOdemeler,
        SecilenYil,
        Sofor,
        SoforKodu,
        NakliyeBolge,
        NakliyePlaka,
        Exception,
        Admin,
        MezatGorevlisi
    }


    public abstract class CurrentSession
    {
        public URETICILER Uretici
        {
            get
            {
                URETICILER a = Get<URETICILER>(SessionKeys.Uretici);

                if (a == default(URETICILER))
                {
                    return null;
                }
                else
                {
                    return a;
                }
            }
        }

        public int UreticiID
        {
            get
            {
                URETICILER Uretici = Get<URETICILER>(SessionKeys.Uretici);

                if (Uretici == null)
                {
                    return 0;
                }
                else
                {
                    return Uretici.URETICI_ID;
                }
            }
        }




        public DateTime FilterDate_Start
        {
            get
            {
                DateTime date = (DateTime)Get(SessionKeys.FilterDate_Start);


                // Normal görüntülemede kontrol amaçlı idi ama gecmiş kayıtlar problem çıkardı.
                //if (date.Year != DateTime.Now.Year)
                //{
                //    date = DateTime.Now;
                //}

                return date;
            }
        }

        public DateTime FilterDate_End
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

        //private static HttpContext _httpContext => new HttpContextAccessor().HttpContext;


        public void Set<T>(SessionKeys key, T obj)
        {
            //_httpContext.Session.Set(key.ToString(),obj);
        }

        public object? Get(SessionKeys key)
        {
            //if (_httpContext[key.ToString()] != null)
            //{
            //    return HttpContext.Session[key.ToString()];
            //}

            return null;
        }

        public T? Get<T>(SessionKeys key)
        {
            //if (HttpContext.Session[key.ToString()] != null)
            //{
            //    return (T)HttpContext.Session[key.ToString()];
            //}

            return default(T);
        }

        public void Remove(SessionKeys key)
        {
            //if (HttpContext.Session[key.ToString()] != null)
            //{
            //    HttpContext.Session.Remove(key.ToString());
            //}
        }

        public void Clear()
        {
            //HttpContext.Current.Session.Clear();
        }
    }
}