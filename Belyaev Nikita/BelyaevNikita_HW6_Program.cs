using System;

namespace HomeWork6
{
    class Program
    {
        static int firstNum;
        static int secondNum;

        static void Main(string[] args)
        {
            bool success = false;
            Console.Write("Type first number : ");

            while(!success)
            {
                success = int.TryParse(Console.ReadLine(), out firstNum);
                if (!success)
                {
                    Console.WriteLine($"Please type integrer number.");
                }
            }

            success = false;
            Console.Write("Type second number : ");

            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out secondNum);
                if (!success)
                {
                    Console.WriteLine($"Please type integrer number.");
                }
            }

            try
            {
                Console.WriteLine($"Result = {Div(firstNum, secondNum)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }

        public static double Div(int firstNum, int secondNum) => firstNum / secondNum;
    }
}
