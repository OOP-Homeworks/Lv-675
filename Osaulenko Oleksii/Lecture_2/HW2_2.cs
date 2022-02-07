using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, min_num, max_num;
            Console.WriteLine($"Please enter integer nomber ¹1");
            max_num = Convert.ToInt32(Console.ReadLine());
            min_num = max_num;
            foreach (int i in Enumerable.Range(2, 2))
            {
                Console.WriteLine($"Please enter integer nomber ¹{i}");
                num = Convert.ToInt32(Console.ReadLine());
                min_num = num < min_num ? num : min_num;
                max_num = num > max_num ? num : max_num;
            }
            Console.WriteLine($"MAX number is {max_num}, MIN number is {min_num}");
            Console.ReadKey();
        }

    }
}