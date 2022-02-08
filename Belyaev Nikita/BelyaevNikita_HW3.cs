using System;

namespace BelyaevNikita_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 : Read some string str. Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.

            Console.Write("Type something : ");
            string answer = Console.ReadLine();

            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;

            foreach (var item in answer)
            {
                switch (item)
                {
                    case 'a':
                        countA++;
                        break;
                    case 'o':
                        countO++;
                        break;
                    case 'i':
                        countI++;
                        break;
                    case 'e':
                        countE++;
                        break;
                }
            }

            Console.WriteLine($"Text have {countA} letters a , {countO} letters o , {countI} letters i , {countE} letters e .");

            // Task 2 : Ask user to enter the number of month. Read value and output the count of days in this month.

            Console.Write("Type number of month : ");
            int numberOfMonth = int.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.DaysInMonth(2022, numberOfMonth) + " days in your month.");

            // Task 3 : Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.

            int[] intArr = new int[] { 5, 6, 1, 0, -3, 9, 1, -5, 6, 7 };

            bool result = true;

            for (int i = 0; i < 5; i++)
            {
                if (intArr[i] < 0)
                {
                    result = false;
                }
            }

            int sum = 0;

            if(result == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum += intArr[i];
                }
            }
            else
            {
                for (int i = 5; i < intArr.Length; i++)
                {
                    sum += intArr[i];
                }
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
