using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>();

            listOfShapes.Add(new Square("square1", 3));
            listOfShapes.Add(new Square("square2", 7));
            listOfShapes.Add(new Square("square3", 4));
            listOfShapes.Add(new Square("square4", 2));
            listOfShapes.Add(new Circle("circle1", 1));
            listOfShapes.Add(new Circle("circle2", 9));
            listOfShapes.Add(new Circle("circle3", 3));
            listOfShapes.Add(new Circle("circle4", 2));

            // 1) Create list of Shape and fill it with 6 different shapes (Circle and Square).

            var newShapeList = from c in listOfShapes
                              where c.Area() > 5
                              select new { c };

            foreach (var item in newShapeList)
            {
                Console.WriteLine(item.ToString());
            }

            // 2) Find and write into the file shapes with area from range [10,100]

            var path = @"C:\Users\hekeemje\Desktop\resultRange.txt";
            FileInfo file = new FileInfo(path);

            if (!file.Exists)
            {
                IEnumerable<Shape> rangeShapes = listOfShapes.Where(c => c.Area() >= 10 && c.Area() <= 100);

                using (StreamWriter sw = file.CreateText())
                {
                    foreach (var item in rangeShapes)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }

            // 3) Find and write into the file shapes which name contains letter 'a'

            var path2 = @"C:\Users\hekeemje\Desktop\resultNameA.txt";
            FileInfo file2 = new FileInfo(path2);

            if (!file2.Exists)
            {
                IEnumerable<Shape> nameAShapes = listOfShapes.Where(c => c.Name.Contains('a'));

                using (StreamWriter sw = file2.CreateText())
                {
                    foreach (var item in nameAShapes)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }

            // 4) Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console 

            listOfShapes.RemoveAll(x => x.Perimetr() < 20); // меньше периметра 5 сложно найти фигуру , поэтому сделал меньше периметра 20

            foreach (var item in listOfShapes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
