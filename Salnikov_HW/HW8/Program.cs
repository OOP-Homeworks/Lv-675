using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salnikov_HW_8
{

    abstract class Shape : IComparable
    {
        private string name;
        public string Name 
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Shape(string name) 
        {
            this.name = name;
        }
        public abstract int CompareTo(object ob);
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape
    { 
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return (Math.Pow(radius,2) * Math.PI);
        }
        public override double Perimeter()
        {
            return (2 * radius * Math.PI) ;
        }

        public override int CompareTo(object ob)
        {
            return (this.Perimeter().CompareTo((ob as Shape).Perimeter()));
        }
    }

    class Square : Shape
    {
        private double side;
        public double Side 
        {
            get { return side; }
            set { side = value; }
        }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return (Math.Pow(side,2));
        }
        public override double Perimeter()
        {
            return (4*side);
        }
        public override int CompareTo(object ob)
        {
            return (this.Perimeter().CompareTo((ob as Shape).Perimeter()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            byte countOfShape = 10;
                string answer, name;

            for (int i = 0; i < countOfShape; i++) 
            {
                Console.WriteLine("Add 1(Circle), 2(Square)");
                answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "circle":
                        Console.Write("Enter the name : ");
                        name = Console.ReadLine();
                        Console.Write("Enter the raduis : ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new(name, radius);
                        shapes.Add(circle);
                        Console.WriteLine($"The{answer} {circle.Name}'s area is {circle.Area()}, perimeter is {circle.Perimeter()}");
                        break;
                    case "square":
                        Console.Write("Enter the name : ");
                        name = Console.ReadLine();
                        Console.Write("Enter the side : ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Square square = new(name, side ); 
                        shapes.Add(square);
                        Console.WriteLine($"The{answer} {square.Name}'s area is {square.Area()}, perimeter is {square.Perimeter()}");
                        break;
                    default:
                        Console.WriteLine("You chose nothing");
                        break;
                }

               
            }
            Shape maxPerimeter = null;
            double maxValue = 0.0;
            for (int j = 0; j < shapes.Count; j++)
            {
                if (shapes[j].Perimeter() > maxValue)
                {
                    maxValue = shapes[j].Perimeter();
                    maxPerimeter = shapes[j];
                }
            }
            Console.WriteLine($"The name of shape with max perimeter - {maxPerimeter.Name}");

            shapes.Sort(delegate (Shape a, Shape b)
            {
                return a.CompareTo(b);
            });
            shapes.Sort(delegate (Shape a, Shape b)
            {
                return a.Area().CompareTo(b.Area());
            });
            Console.WriteLine("Sorted:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"The name: {shape.Name}" +
                    $", area: {shape.Area()}" +
                    $", perimeter: {shape.Perimeter()}");
            }

        }
    }
}
