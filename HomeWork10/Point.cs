using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codin
{
    public struct Point
    {
        public int X, Y;
        public Point(int x, int y) { this.X = x; this.Y = y; }

        public override string ToString()
        {
            return $"(x{X},y{Y})";
        }
    }
}
