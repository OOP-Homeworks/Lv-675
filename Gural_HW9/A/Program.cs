using System;
using System.Collections.Generic;
using System.IO;

namespace Gural_HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("1a", 1));
            shapes.Add(new Square("1b", 3));
            shapes.Add(new Circle("2c", 6));
            shapes.Add(new Square("2d", 5));
            shapes.Add(new Circle("3e", 54));
            shapes.Add(new Square("3u", 24));


            Console.WriteLine("List of shapes");
            foreach(Shape i in shapes)
            {
                Console.WriteLine("Name: {0}, Area: {1}, Perimeter: {2}", i.Name, i.Area(), i.Perimeter());
            }
            Console.WriteLine();

            Console.WriteLine("The shape with area in range [10:100]:");
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Area() >= 10 && shapes[i].Area() <= 100)
                {
                    Console.WriteLine($"Name: {shapes[i].Name}, value of area: {shapes[i].Area()}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("The shape which contains 'a':");
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Name.Contains("a"))
                {
                    Console.WriteLine($"Name: {shapes[i].Name}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shapes after removing if has perimeter < 5: ");
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() < 5)
                {
                    shapes.Remove(shapes[i]);
                }
                Console.WriteLine($"The name of shape: {shapes[i].Name}, perimeter: {shapes[i].Perimeter()}, area: {shapes[i].Area()}");
            }
        }
    }
}
