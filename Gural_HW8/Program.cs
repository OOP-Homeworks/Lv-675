using System;
using System.Collections.Generic;

namespace Gural_HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            List<Shape> shapes = new List<Shape>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter name of " + i + " elem:\ns to Square; c to Circle");
                string name = Console.ReadLine();
                Console.WriteLine("Enter side for " + i + " elem:");
                double side = Double.Parse(Console.ReadLine());
                if(name == "s")
                {
                    shapes.Add(new Square(name, side));
                }
                else if(name == "c")
                {
                    shapes.Add(new Circle(name, side));
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();
            Print(shapes);
            //b

            Shape maxPerShape = null;
            double maxPer = 0;

            for(int i = 0; i < shapes.Count; i++)
            {
                if(shapes[i].Perimeter() > maxPer)
                {
                    maxPer = shapes[i].Perimeter();
                    maxPerShape = shapes[i];
                }
            }
            Console.WriteLine("Max perimeter in list of shapes = {0}", maxPer);

            //3
            Console.WriteLine("Sorted by area");
            shapes.Sort(delegate (Shape a, Shape b)
            {
                return a.Area().CompareTo(b.Area());
            });
            Print(shapes);
        }

        static void Print(List<Shape> shapes)
        {
            foreach(Shape i in shapes)
            {
                Console.WriteLine("The name: {0}" +
                    "\narea: {1}\n" +
                    "perimeter: {2}", i.Name, i.Area(), i.Perimeter());
                Console.WriteLine();
            }
        }
    }
}
