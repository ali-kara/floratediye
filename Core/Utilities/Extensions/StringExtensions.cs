using System;
namespace Core.Utilities.Extensions
{
	public static class StringExtensions
	{
        public static string ToCurrency(this decimal decimalValue)
        {
            return $"{decimalValue:C}";
        }
    }
}

