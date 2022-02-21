using System;

namespace HomeWork6_2
{
    class Program
    {
        static int number;

        static void Main(string[] args)
        {
            Console.Write("Write number start of range : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Write number end of range : ");
            int end = int.Parse(Console.ReadLine());

            try
            {
                ReadNumber(start, end);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }

        public static void ReadNumber(int start, int end)
        {
            bool success = true;

            while (success)
            {
                Console.Write($"Write number to check if its in range : ");

                success = int.TryParse(Console.ReadLine(), out number);
                if (!success)
                {
                    throw new Exception("Your number is not INT.");
                }

                if (number >= start && number <= end)
                {
                    Console.WriteLine($"Your number {number} in right range.");
                }
                else
                {
                    throw new Exception("Your number not in range");
                }
            }
        }
    }
}
