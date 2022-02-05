using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, number3;

            Console.WriteLine("Enter the first number: ");
            number1 = float.Parse(Console.ReadLine());
            string answer1 = (number1 >= -5 && number1 <= 5) ? "Number1 in range [-5.5]" : "Number1 out of range"; // Using Ternary operator to find number in range
            Console.WriteLine(answer1);

            Console.WriteLine("Enter the second number ");
            number2 = float.Parse(Console.ReadLine());
            string answer2 = (number2 >= -5 && number2 <= 5) ? "Number2 in range [-5.5]" : "Number2 out of range"; // Using Ternary operator to find number in range
            Console.WriteLine (answer2);

            Console.WriteLine("Enter the third number ");
            number3 = float.Parse(Console.ReadLine());
            string answer3 = (number3 >= -5 && number3 <= 5) ? "Number3 in range [-5.5]" : "Number3 out of range"; // Using Ternary operator to find number in range
            Console.WriteLine(answer3);

            Console.WriteLine($"\nYour {answer1}\nYour {answer2}\nYour {answer3}"); // Output all info 
        }
    }
}
