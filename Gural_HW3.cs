using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter some text");
            int sum = 0;
            string str = Console.ReadLine();
            foreach(char i in str)
            {
                if(i == 'a' || i == 'o' || i == 'i' || i == 'e')
                {
                    sum++;
                }
            }
            Console.WriteLine("We have {0} characters a,o,i,e", sum);
            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine();

            Console.WriteLine("Task 2");
            Console.WriteLine("Enter your number of month");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your number of year");
            int year = Int32.Parse(Console.ReadLine());
            int days = DateTime.DaysInMonth(year, month);
            Console.WriteLine("We have {0} days in {1}.{2}", days, month, year);
            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine();
            
            Console.WriteLine("Task 3");
            int n = 10;
            bool check = true;
            int[] num = new int[n];
            int result = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number {0}", i+1);
                num[i] = Int32.Parse(Console.ReadLine());
                if(num[i] < 0 && i <=n/2 - 1)
                {
                    check = false;
                }
            }
            if(check)
            {
                for(int i = 0; i < n/2; i++)
                {
                    result += num[i];
                }
                Console.WriteLine("Result: {0}", result);
            }
            else
            {
                result++;
                for(int i = n/2 - 1; i < n; i++)
                {
                    result *= num[i];
                }
                Console.WriteLine("Result: {0}", result);
            }

            Console.ReadKey();
        }
    }
}
