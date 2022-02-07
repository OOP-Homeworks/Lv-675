using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            float min_num, max_num, f_num;
            string message;
            min_num = -5;
            max_num = 5;
            foreach (int i in Enumerable.Range(1, 3))
            {
                Console.WriteLine($"Please enter float nomber №{i}");
                f_num = (float) Convert.ToDouble(Console.ReadLine());
                message = (f_num >= min_num && f_num <= max_num) ? message = $"Your number {f_num} in range [-5.5]" : message = $"Your number {f_num} NOT in range [-5.5]";
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }

    }
}
