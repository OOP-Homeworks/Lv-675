using System;
using System.Collections.Generic;
using System.Linq;

namespace HM_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new();
            for (int i = 0; i <= 4; i++) 
            {
                Circle circle = new(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
                shapes.Add(circle);
                Square square = new(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
                shapes.Add(square);

                if (i == 4)
                {
                    foreach (Shape p in shapes)
                    {
                        Console.WriteLine($"Імя:{p.Name} \nПлоща: {p.Area()} \nПериметр: {p.Perimeter()}");
                    }
                    Console.WriteLine($"\nMax value={Convert.ToDouble(shapes.Max().Perimeter())}");
                    var sorted = from p in shapes
                                 orderby p.Area()
                                 select p;
                    foreach (var b in sorted)
                    {
                        Console.WriteLine($"\nІмя:{ b.Name} \nПлоща: { b.Area()} \nПериметр: { b.Perimeter()}");
                    }
                } 
            } 
            
        }
    }
}
