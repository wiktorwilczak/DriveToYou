using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou
{
    public static class ExtensionMethods
    {
    
        public static decimal RemovingKmSuffix(this string input)
        {
            return decimal.Parse(input.Replace("km", "").Replace(" ", "").Replace(".", ","));
        }
    }
}
