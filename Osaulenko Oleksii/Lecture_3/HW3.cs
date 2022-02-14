using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitPoint = true;
            do
            {
                Console.WriteLine("\n\nHW-2 \n 1) Task 1 \n 2) Task 2 \n 3) Task 3 \n 4) Exit");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Exiting();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (exitPoint);

            void Task1()
            {
                string[] letters = { "a", "o", "i", "e" };
                Console.Write("Enter text:");
                string input_str = Console.ReadLine();
                foreach (string i in letters)
                {
                    int count = input_str.Count(x => i.Contains(x));
                    Console.WriteLine($"Letter \"{i}\" meets {count} times");

                }
                Console.ReadKey();
            }

            void Task2()
            {
                Console.WriteLine("Enter year:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter month:");
                int month = Convert.ToInt32(Console.ReadLine());
                int count_of_day = DateTime.DaysInMonth(year, month);
                Console.Write($"In {month} month {year} year {count_of_day} days!");
                Console.ReadKey();
            }

            void Task3()
            {
                bool positive = true;
                int[] data = new int[10];
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine("Enter integer number:");
                    data[i] = Convert.ToInt32(Console.ReadLine());
                    if (data[i] < 0)
                    {
                        positive = false;
                    }
                }

                if (positive)
                {
                    int sum_first_five = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        sum_first_five += data[j];
                    }
                    Console.WriteLine($"All elements are positive. Sum of first five elements = {sum_first_five}.");
                }
                else
                {
                    int prod_last_five = 1;
                    for (int k = 5; k < data.Length; k++)
                    {
                        prod_last_five *= data[k];
                    }
                    Console.WriteLine($"Not all elements are positive. Product of last five elements = {prod_last_five}.");
                }
                Console.ReadKey();
            }

            void Exiting()
            {
                Console.Write("\n Exiting!....");
                exitPoint = false;
            }
        }

    }
}