using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int count = 4;
                List <Shape> shapes = new List<Shape>();
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Would you like to add Square(1) or Circle(2) ?");
                    int choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Enter name of Square:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter side for Square: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            shapes.Add(new Circle(name, side));
                            break;
                        case 2:
                            Console.WriteLine("Enter name of Circle: ");
                            string name2 = Console.ReadLine();
                            Console.WriteLine("Enter radius for Circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            shapes.Add(new Circle(name2, radius));
                            break;
                        default:
                            Console.WriteLine("Error");
                            throw new ArgumentException("Value should be \'1\' or \'2\'.");
                    }
                }
                Print(shapes);
                // Find shape with MAX Perimeter
                string nameMax = "";
                double maxValue = -1;
                for (int i = 0; i < shapes.Count; i++) { 
                    if (shapes[i] is Square)
                    {
                        if (shapes[i].Perimeter((shapes[i] as Square).Side) > maxValue)
                        {
                            maxValue = shapes[i].Perimeter((shapes[i] as Square).Side);
                            nameMax = shapes[i].Name;
                        }
                    }
                    else
                    {
                        if (shapes[i].Perimeter((shapes[i] as Circle).Radius) > maxValue)
                        {
                            maxValue = shapes[i].Perimeter((shapes[i] as Circle).Radius);
                            nameMax = shapes[i].Name;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("max perimeter - " + nameMax + " maxValue - " + maxValue);
                
                shapes.Sort(delegate (Shape a, Shape b)
                {
                    return a.CompareTo(b);
                });

                Console.WriteLine();
                Console.WriteLine("Sorted by perimeter");
                Print(shapes);
                Console.WriteLine();

                // Sort Shapes by Area & Print
                Console.WriteLine("\n Sorted by area: ");
                shapes.Sort(delegate (Shape a, Shape b)
                {
                    if (a is Square && b is Square)
                    {
                        return a.Area((a as Square).Side).CompareTo(b.Area((b as Square).Side));
                    }
                    else if (a is Circle && b is Square)
                    {
                        return a.Area((a as Circle).Radius).CompareTo(b.Area((b as Square).Side));
                    }
                    else if (a is Square && b is Circle)
                    {
                        return a.Area((a as Square).Side).CompareTo(b.Area((b as Circle).Radius));
                    }
                    else
                        return a.Area((a as Circle).Radius).CompareTo(b.Area((b as Circle).Radius));
                });
                Print(shapes);           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        static void Print(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                if (shape is Circle)
                {
                    Console.WriteLine("The name: " + shape.Name +
                        ", area of shape: " + shape.Area((shape as Circle).Radius) +
                        ", perimeter of shape: " + shape.Perimeter((shape as Circle).Radius));
                }
                else
                {
                    Console.WriteLine("The name: " + shape.Name +
                        ", area of shape: " + shape.Area((shape as Square).Side) +
                        ", perimeter of shape: " + shape.Perimeter((shape as Square).Side));
                }
            }
        }
    }
}
