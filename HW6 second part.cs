using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_2
{
    internal class Program
    {
        public static void ReadNumbers(int start, int end)
        {
        begin1:
            List<int> mas = new List<int>();
            int[] variable = new int[10];
            int counting = 1;

            if (start > end || start < 0 || end < 0 || start == end)
            {
                Console.WriteLine("Enter the right range! 1 > 100...");
                goto begin1;
            }
            begin2:
            try
            {
                for (int i = 0; i < variable.Length; i++)
                {
                    Console.Write($"Enter number {counting}: ");
                    variable[i] = Convert.ToInt32(Console.ReadLine());
                    counting++;

                    if (variable[i] >= start && variable[i] <= end)
                    {
                        Console.WriteLine($"\nNumber which you inputed in the range of {start} and {end}\n");
                        mas.Add((variable[i]));
                    }
                    else
                    {
                        throw new Exception("Number in not range or you trying to enter the line of symbols!");
                    }
                }
                foreach (int c in mas)
                {
                    Console.WriteLine($"Answer: {c}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                goto begin2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to numbers (range)");
            Console.Write("The first one pls: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("And the another one: ");
            int end = Convert.ToInt32(Console.ReadLine());
            
            ReadNumbers(start, end);
        }
    }
}
