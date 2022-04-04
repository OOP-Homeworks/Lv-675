using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW8
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
            return Math.PI * 2 * radius;
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Radius = " + radius;
        }

        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }
}
