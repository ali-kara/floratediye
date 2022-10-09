using System;
namespace Core.Web.Utilities
{
    public static class ToCurreny
    {
        public static string ToCurrency(this decimal decimalValue)
        {
            return $"{decimalValue:C}";
        }
    }
}

