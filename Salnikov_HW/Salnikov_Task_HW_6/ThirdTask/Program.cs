using System;

namespace Task5_3
{
    public class NumberRange
    {

        class Program
        {
            static void ReadNumber(int start, int end)
            {

                int[] allNumbers = new int[10];
            
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                a1:
                    try
                    {
                        Console.Write($"Enr {i+1} number : ");
                        allNumbers[i] = int.Parse(Console.ReadLine());
                        if (allNumbers[i] < start || allNumbers[i] > end)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid format of input!");
                        Console.ReadLine();
                        goto a1;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The number is out of the range!");
                        Console.ReadLine();
                        goto a1;
                    }
                    start = allNumbers[i]; 
                }
            }
            static void Main()
            {
                int start = 1;
                int end = 100;
                ReadNumber(start, end);
            }
        }
    }
}

