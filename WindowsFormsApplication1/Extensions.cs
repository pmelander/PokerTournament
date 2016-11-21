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

        public static bool IsBlind(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true;
            var blinds = value.Split('/');
            if (blinds.Length != 2) return false;
            return blinds[0].IsNumericOrEmpty() && blinds[1].IsNumericOrEmpty();
        }

        public static int GetBB(this string value)
        {
            if (!value.IsBlind()) return 0;
            var blinds = value.Split('/');
            return int.Parse(blinds[0]);
        }

        public static int GetSB(this string value)
        {
            if (!value.IsBlind()) return 0;
            var blinds = value.Split('/');
            return int.Parse(blinds[1]);
        }
    }
}
