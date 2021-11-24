using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class DoubleExtensions
    {
        public static bool CloseTo(this double a, double b)
            => System.Math.Abs(a - b) < 0.0000001;
    }
}
