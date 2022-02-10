using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int product;
            int[] Array = new int[10]; // created an array to receive 10 digits from the user
            Console.WriteLine("Enter first number: ");
            Array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            Array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            Array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            Array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fifth number: ");
            Array[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sixth number: ");
            Array[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seventh number: ");
            Array[6] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter eighth number: ");
            Array[7] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ninth number: ");
            Array[8] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tenth number: ");
            Array[9] = Convert.ToInt32(Console.ReadLine());


            /* we check all the numbers are positive, if yes, we consider
             the sum of the first five, if - no. We multiply the last five. */
            if (Array[0] > 0 && Array[1] > 0 && Array[2] > 0 && Array[3] > 0 && Array[4] > 0
                    && Array[1] > 0 && Array[1] > 0 && Array[1] > 0 && Array[1] > 0 && Array[1] > 0)
            {
                sum = Array[0] + Array[1] + Array[2] + Array[3] + Array[4];
                Console.WriteLine();
                Console.WriteLine($"The sum of the first five digits: " +
                    $"{sum} = {Array[0]} + {Array[1]} + {Array[2]} + {Array[3]} + {Array[4]}");
            }
            else
            {
                product = Array[5] * Array[6] * Array[7] * Array[8] * Array[9];
                Console.WriteLine();
                Console.WriteLine($"The product of the last five digits: " +
                    $"{product} = {Array[5]} * {Array[6]} * {Array[7]} * {Array[8]} * {Array[9]}");
            }
            Console.WriteLine("Thanks for using my little program! Have a good day!");
            Console.ReadKey();
        }
    }
}

