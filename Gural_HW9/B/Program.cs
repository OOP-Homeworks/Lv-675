using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gural_HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";
            string[] text = File.ReadAllLines(file);

            foreach(string i in text)
            {
                Console.WriteLine("Line length = " + i.Length);
            }
            Console.WriteLine();

            var Max = text.OrderByDescending(a => a.Length).First().ToString();
            var Min = text.OrderBy(a => a.Length).First().ToString();

            Console.WriteLine("Max length = " + Max.Length);
            Console.WriteLine("Min length = " + Min.Length);
            Console.WriteLine();

            Console.WriteLine("Line consist var");
            foreach(string line in text)
            {
                if (line == "var")
                {
                    Console.WriteLine(line);
                }

            }
        }
    }
}
