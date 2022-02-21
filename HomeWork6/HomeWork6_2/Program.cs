using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    internal class Program : Exception
    {
       

        public static void ReadNumber(int start, int end)
        {
            begin1:
                List<int> number = new List<int>();
                int[] variable = new int[10];

                if (start > end || start < 0 || end < 0 || start == end || start == 0 || end == 0)
                {
                    Console.WriteLine("Enter the right range! 1 > 100...");
                    goto begin1;
                }

        mark1:
            try
            {
                for (int i = 0; i < variable.Length; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    variable[i] = Convert.ToInt32(Console.ReadLine());


                    if (variable[i] >= start && variable[i] <= end)
                    {
                        Console.WriteLine($"\nNumber in the range of {start} and {end}\n");
                        number.Add(variable[i]);
                    }
                    else
                    {
                        throw new Exception("Number is not in range or you trying to enter the line of symbols!");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not int type! ENTER INT!!");
                goto mark1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                goto mark1;
            }          

            foreach (int c in number)
            {
              Console.WriteLine($"Answer: {c}");
            }
        }

        static void Main()
        {
            Console.Write("Enter begin of range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            ReadNumber(start, end);


        }
    }
}
