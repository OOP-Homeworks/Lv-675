using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> shapes = new List<Shape>();
                shapes.Add(new Circle("First circle", 2));
                shapes.Add(new Square("First square", 1));
                shapes.Add(new Circle("Second circle", 3));
                shapes.Add(new Square("Second square", 5));
                shapes.Add(new Circle("Third circle", 50));
                shapes.Add(new Square("Third square", 22));

                string path = @"E:\Programming\HomeWork for SoftServe\Home Work 9\file.txt";

                if (!File.Exists(path))
                    using (FileStream fs = File.Create(path));

               

                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine("List of shapes: ");

                    foreach(Shape shape in shapes)
                    {
                        sw.WriteLine($"The name of shape: {shape.Name}, with area: {shape.Area()}, with perimeter: {shape.Perimeter()}");
                    }
                    sw.WriteLine();

                    sw.WriteLine("The shape with area in range [10:100]: ");
                    for (int i = 0; i < shapes.Count; i++)
                    {
                        if (shapes[i].Area() >= 10 && shapes[i].Area() <= 100)
                        {
                           sw.WriteLine($"Name: {shapes[i].Name}, value of area: {shapes[i].Area()}");
                        }
                    }
                    sw.WriteLine();

                    sw.WriteLine("The shape which contains 'a': ");

                    for (int i = 0; i < shapes.Count; i++)
                    {
                         if (shapes[i].Name.Contains("a"))
                         {
                            sw.WriteLine($"Name: {shapes[i].Name}");
                         }
                    }
                    sw.WriteLine();

                    sw.WriteLine("Shapes after removing if has perimeter < 5: ");
                    for (int i = 0; i < shapes.Count; i++)
                    {
                        if (shapes[i].Perimeter() < 5)
                        {
                            shapes.Remove(shapes[i]);
                        }
                        sw.WriteLine($"The name of shape: {shapes[i].Name}, perimeter: {shapes[i].Perimeter()}, area: {shapes[i].Area()}");
                    }
                }

                

                string text = File.ReadAllText(path);
                Console.WriteLine(text);

            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
