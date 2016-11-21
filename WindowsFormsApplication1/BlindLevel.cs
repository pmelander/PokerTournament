using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BlindLevel
    {
        public BlindLevel(int bb, int sb, int timeInMinutes)
        {
            BB = bb;
            SB = sb;
            TimeInSeconds = timeInMinutes * 60;
        }

        public int BB { get; set; }
        public int SB { get; set; }
        public int TimeInSeconds { get; set; }
    }
}
