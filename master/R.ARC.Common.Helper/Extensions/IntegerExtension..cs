﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Common.Helper.Extensions
{
    public static class TntegerExtensions
    {
        public static List<int> CountListesineCevir(this string str, char separetor = ',')
        {
            return str.Coalesce().Split(separetor, StringSplitOptions.RemoveEmptyEntries).Where(x => int.TryParse(x, out int parsed)).Select(x => int.Parse(x)).ToList();
        }        
    }
}
