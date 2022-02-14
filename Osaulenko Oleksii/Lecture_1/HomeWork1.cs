using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side lenth of a square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int area_sqr = a * a;
            int perim_sqr = a * 4;
            Console.WriteLine($"area of a square = {area_sqr}");
            Console.WriteLine($"perimeter of a square = {perim_sqr}");
            Console.WriteLine();


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name}, and you are {age}");
            Console.WriteLine();


            Console.WriteLine("Enter radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double len_circle = 2 * Math.PI * r;
            double area_circle = Math.PI * r * r;
            double volume_circle = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"Length of a circle = {len_circle}");
            Console.WriteLine($"Area of a circle = {area_circle}");
            Console.WriteLine($"Volume of a circle = {volume_circle}");
        }

    }
}