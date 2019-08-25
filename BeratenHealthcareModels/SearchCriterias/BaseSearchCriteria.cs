using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BeratenHealthcareModels
{
    public abstract class BaseSearchCriteria 
    {

        public string ToQueryString()
        {
            var query = (from p
                in GetType().GetProperties()
                    .Where(p => p.GetValue(this) != null)
                         select new KeyValuePair<string, string>(p.Name, p.GetValue(this).ToString()))
                .Aggregate("",
                    (s, pair) => s + string.Format("{0}={1}&", pair.Key, pair.Value)).TrimEnd('&');
            return Uri.EscapeUriString(query);
        }
    }
}