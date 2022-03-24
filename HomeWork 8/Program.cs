using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Program
    {
        enum ShapeEnum : int
        {
            Square = 1,
            Circle = 2
        }


        static void Main(string[] args)
        {
            try
            {
                const int count = 10;
                List <Shape> shapes = new List<Shape>();
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Would you like to add Square(1) or Circle(2) ?");
                    ShapeEnum shapeEnum = (ShapeEnum)int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter name of " + shapeEnum + ": ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter side for " + shapeEnum + ": ");
                    double secondParameter = Convert.ToDouble(Console.ReadLine());
                    if (shapeEnum == ShapeEnum.Square)
                    {
                        shapes.Add(new Square(name, secondParameter));
                    }
                    else if (shapeEnum == ShapeEnum.Circle)
                    {
                        shapes.Add(new Circle(name, secondParameter));
                    }
                    else
                        throw new ArgumentException("Value should be \'1\' or \'2\'.");
                }
                Console.WriteLine();
                Print(shapes);

                // Find shape with MAX Perimeter

                Shape maxPerimeterShape = null;
                double maxValue = -1;

                for (int i = 0; i < shapes.Count; i++) { 
                    if (shapes[i].Perimeter() > maxValue)
                    {
                        maxValue = shapes[i].Perimeter();
                        maxPerimeterShape = shapes[i];
                    }
                }
                Console.WriteLine($"The name of shape with max perimeter - {maxPerimeterShape.Name}, max perimeter is equal: {maxValue}");                
                shapes.Sort(delegate (Shape a, Shape b)
                {
                    return a.CompareTo(b);
                });

                Console.WriteLine();
                Console.WriteLine("Sorted by perimeter");
                Print(shapes);
                Console.WriteLine();

                // Sort Shapes by Area & Print
                Console.WriteLine("Sorted by area: ");
                shapes.Sort(delegate (Shape a, Shape b)
                {
                    return a.Area().CompareTo(b.Area());
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
            foreach (HomeWork8.Shape shape in shapes)
            {
                Console.WriteLine($"The name: {shape.Name}" +
                    $", area: {shape.Area()}" +
                    $", perimeter: {shape.Perimeter()}");                
            }
        }
    }
}
