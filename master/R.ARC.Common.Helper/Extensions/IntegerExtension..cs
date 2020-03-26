using System;
using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Common.Helper.Extensions
{
    public static class TntegerExtensions
    {
        public static List<int> ConvertCountList(this string str, char separetor = ',')
        {
            return str.Coalesce().Split(separetor).Where(x => int.TryParse(x, out int parsed)).Select(x => int.Parse(x)).ToList();
        }        
    }
}
