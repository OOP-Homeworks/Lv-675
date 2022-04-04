using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW10
{
    public struct Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"(x{x},y{y})";
        }
    }
}
