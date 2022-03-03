using System;
using System.Collections.Generic;

namespace HomeWork6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] rangeNums = new int[2];
            int[] correctNums = new int[10];
            int numToEnd = 10;

            for (bool flag = true; flag;)
            {
            point1:
                try
                {
                    Console.WriteLine("Enter start number");
                    rangeNums[0] = Int32.Parse(Console.ReadLine());
                    flag = false;
                    Console.WriteLine("OK");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"ERROR!!! Enter integer number! {ex.Message}");
                    goto point1;
                }
            }

            for (bool flag = true; flag;)
            {
            point2:
                try
                {
                    Console.WriteLine("Enter end number");
                    rangeNums[1] = Int32.Parse(Console.ReadLine());
                    if (rangeNums[1] - rangeNums[0] < numToEnd - 1)
                    {
                        throw new Exception("ERROR!!! End number must be bigest more then 10");
                        goto point2;
                    }
                    flag = false;
                    Console.WriteLine("OK");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"ERROR!!! Enter integer number! {ex.Message}");
                    goto point2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto point2;
                }
            }

            
            for (int i = 0; i < 10;)
            {
            point3:            
                try
                {                  
                    Console.WriteLine($"Enter num {i + 1} in range [{rangeNums[0]},{rangeNums[1] - numToEnd + (i + 1)}] include");
                    int num = Int32.Parse(Console.ReadLine());
                    if (num >= rangeNums[0] && num <= (rangeNums[1] - numToEnd + (i + 1)))
                    {
                        rangeNums[0] = num + 1;
                        correctNums[i] = num;
                        i++;
                    }
                    else
                    {
                        throw new Exception($"ERROR!!! Enter number in range [{rangeNums[0]},{rangeNums[1] - numToEnd + (i + 1)}] include");
                        goto point3;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"ERROR!!! Enter integer number! {e.Message}");
                    goto point3;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto point3;
                }
            }
            Console.Write("Your numbers are - ");
            Console.WriteLine("{0}", string.Join(", ", correctNums));
            Console.ReadKey();
        }
    }
}
