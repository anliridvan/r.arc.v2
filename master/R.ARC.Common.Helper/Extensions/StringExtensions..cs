using System;
using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Common.Helper.Extensions
{
    public static class StringExtensions
    {
        public static List<string> ConvertList(this string str, char separetor = ',')
        {
            return str.Coalesce().Split(separetor, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public static string Coalesce(this string str, string defaultValue = "")
        {
            return str ?? defaultValue;
        }
    }
}
