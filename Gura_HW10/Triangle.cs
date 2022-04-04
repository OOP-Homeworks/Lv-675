using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW10
{
    public class Triangle
    {
        private double perimeter;
        private double side1, side2, side3;
        private Point a, b, c;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
            Sides();
        }

        public void Sides()
        {
            side1 = Math.Pow(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2), 0.5);
            side2 = Math.Pow(Math.Pow(b.x - c.x, 2) + Math.Pow(b.y - c.y, 2), 0.5);
            side3 = Math.Pow(Math.Pow(c.x - a.x, 2) + Math.Pow(c.y - a.y, 2), 0.5);
        }

        public double Perimeter()
        {
            perimeter = Math.Round(side1 + side2 + side3, 2);
            return perimeter;
        }
        public double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            double area = Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3)), 2);
            return area;
        }
    }
}
