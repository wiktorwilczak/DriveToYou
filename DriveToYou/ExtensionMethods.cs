using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriveToYou
{
    public static class ExtensionMethods
    {
        static DateTime Trim(this DateTime date, long roundTicks)
        {
            return new DateTime(date.Ticks - date.Ticks % roundTicks, date.Kind);
        }
    }
}