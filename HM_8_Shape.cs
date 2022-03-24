using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_8
{
    abstract class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area() { return Radius* Radius *3.14; }
        public override double Perimeter() { return Radius * 2 * 3.14; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
    }

    class Square : Shape
    {
        public double Side { get; set; }
        public override double Area() { return Side * Side; }
        public override double Perimeter() { return Side * 4; }
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
    }
}
