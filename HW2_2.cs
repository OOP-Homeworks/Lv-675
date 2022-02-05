using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, max, min;
            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            max = Math.Max(number1, Math.Max(number2,number3)); // Using a Math metod to define max number
            min = Math.Min(number1, Math.Min(number2,number3)); // Using a Math metod to difene min number
            Console.WriteLine($"The max number is {max}\nThe min number is {min}"); // Output answer
        }
    }
}
