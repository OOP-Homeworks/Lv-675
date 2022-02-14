using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal class Program
    {
        public static void Numbers()  // Creating method
        {
            int counting;
            int [] variable = new int[10]; // Creating array

            counting = 1;
            do
            {
                Console.WriteLine($"Enter the number {counting}");  
                variable[0] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[1] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[2] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[3] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[4] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[5] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[6] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[7] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[8] = Convert.ToInt32(Console.ReadLine());
                counting++;                                         // just increase the number of "counting"
                Console.WriteLine($"Enter the number {counting}");
                variable[9] = Convert.ToInt32(Console.ReadLine());
                break;
            }
            while (counting < 10);
            Console.WriteLine("Your numbers:");
            var str = string.Join(", ", variable); // Output all array "variable"
            Console.WriteLine(str);


            if (variable[0] >= 0 && variable[1] >= 0 && variable[2] >= 0 && variable[3] >= 0 && variable[4] >= 0)
            {
                int resultOfSum = variable[0] + variable[1] + variable[2] + variable[3] + variable[4];
                Console.WriteLine($"The sum of first 5 numbers is: {resultOfSum}");
            }
            else
            {
                int resultOfProduct = variable[5] * variable[6] * variable[7] * variable[8] * variable[9];
                Console.WriteLine($"The product of last 5 numbers is: {resultOfProduct}");
            }
        }
        static void Main(string[] args)
        {
            Numbers(); // Using method
        }
    }
}
