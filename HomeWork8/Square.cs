using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Square : Shape
    {
        private double side;

        public double Side { get { return side; } }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area(double side)
        {
            return side * side;
        }

        public override double Perimeter(double side)
        {
            return 2 * (side + side);
        }

        public override string ToString()
        {
            return "Name is " + Name + ", side is " + side;
        }

        public override int CompareTo(object obj)
        {
            Shape other = (Shape)obj;
            if (other is Square)
            {
                return this.Perimeter(side).CompareTo(other.Perimeter((other as Square).Side));
            }
            return this.Perimeter(side).CompareTo(other.Perimeter((other as Circle).Radius));
        }
    }
}
