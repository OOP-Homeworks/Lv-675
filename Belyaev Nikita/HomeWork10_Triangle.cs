using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justCoding
{
    public class Triangle
    {
        private double firstSide, secondSide, thirdSide;
        private Point p1, p2, p3;
        private double perimeter;
        public Triangle(Point a, Point b, Point c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
            Sides();
        }

        public double Perimeter()
        {
            perimeter = firstSide + secondSide + thirdSide;
            perimeter = Math.Round(perimeter, 2);
            return perimeter;
        }
        public double Square()
        {
            double square = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));
            square = Math.Round(square, 2);
            return square;
        }
        public void Print()
        {

        }

        public void Sides()
        {
            firstSide = Math.Pow(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2), 0.5);
            secondSide = Math.Pow(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2), 0.5);
            thirdSide = Math.Pow(Math.Pow(p3.X - p1.X, 2) + Math.Pow(p3.Y - p1.Y, 2), 0.5);
        }
    }
}
