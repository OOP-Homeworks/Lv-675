using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>();

            for (var i = 0; i < 2; i++)
            {
                Console.Write("Please, type name for Circle : ");
                string name = Console.ReadLine();
                Console.Write("Please, type radius ( int number ) for Circle : ");
                var radius = int.Parse(Console.ReadLine());
                listOfShapes.Add(new Circle(name,radius));
            }

            for (var i = 0; i < 2; i++)
            {
                Console.Write("Please, type name for Square : ");
                string name = Console.ReadLine();
                Console.Write("Please, type length of side ( int number ) for Square : ");
                var length = int.Parse(Console.ReadLine());
                listOfShapes.Add(new Square(name, length));
            }

            foreach (var item in listOfShapes)
            {
                Console.WriteLine(item.ToString());
            }

            Shape largestPerimetr = listOfShapes[0];

            foreach (var item in listOfShapes)
            {
                if (item.Perimetr() > largestPerimetr.Perimetr())
                {
                    largestPerimetr = item;
                }
            }

            Console.WriteLine($"{largestPerimetr.Name} have largest Perimetr;");

            listOfShapes.Sort();

            foreach (var item in listOfShapes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
