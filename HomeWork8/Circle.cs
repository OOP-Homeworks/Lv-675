using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius; } }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return "Name is " + Name + ", Radius is " + radius;
        }
        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }
}
