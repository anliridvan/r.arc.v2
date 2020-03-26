using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Common.Helper.Extensions
{
    public static class EnumarableExtensions
    {
        public static string ConvertString(this IEnumerable<string> strEnumarable, string separetor = ",")
        {
            if (strEnumarable == null)
                return null;

            return string.Join(separetor, strEnumarable);
        }
    }
}
