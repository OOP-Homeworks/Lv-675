using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_1
{
    internal class Square : Shape
    {
        private double side;

        public double Side { get { return side; } }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 2 * (side + side);
        }

        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }
}
