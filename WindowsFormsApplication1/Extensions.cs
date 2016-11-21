using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Extensions
    {
        public static bool IsNumericOrEmpty(this string value)
        {
            int retVal;
            return string.IsNullOrWhiteSpace(value) || int.TryParse(value, out retVal);
        }

        public static bool IsNumeric(this string value)
        {
            int retVal;
            return int.TryParse(value, out retVal);
        }
    }
}
