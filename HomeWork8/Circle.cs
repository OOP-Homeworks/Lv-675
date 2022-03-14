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

        public Circle(string name,double radius ) : base(name)
        {
            this.radius = radius;
        }

        public override double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter(double radius)
        {
            return Math.PI * 2 * radius;
        }

        public override string ToString()
        {
            return "Name is " + Name + ", Radius is " + radius;
        }

        public override int CompareTo(object obj)
        {
            Shape other = (Shape)obj;
            if (other is Circle)
            {
                return this.Perimeter(radius).CompareTo(other.Perimeter((other as Circle).Radius));
            }
            return this.Perimeter(radius).CompareTo(other.Perimeter((other as Square).Side));
        }


    }
}
