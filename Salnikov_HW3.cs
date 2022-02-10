using System;
using System.Linq;


namespace Salnikov_HW3
{

    class Program
    {
        static void Main(string[] args)
        {

            bool exitPoint = true;
            
            do
            {
                Console.Write("Press enter to continue -  ");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\nHW-2 \n 1) Task 1(LINQ) \n 2) Task 1(Whithout LONQ) \n 3) Task 2 \n 4) Task 3 \n 5) Exit");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Task1Linq();
                        break;
                    case 2:
                        Task1WhithoutLinq();
                        break;
                    case 3:
                        Task2();
                        break;
                    case 4:
                        Task3();
                        break;
                    case 5:
                        Exiting();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (exitPoint);


            //methods

            void Task1Linq() 
            {
                //Task 1 (the first way -  using LINQ)

                 Console.WriteLine("Enter a sentence ");
                 string inputstring = Console.ReadLine();

                 var count = 0;

                 var charGroups = (from s in inputstring
                                   group s by s into g
                                   select new
                                   {
                                       c = g.Key,
                                       count = g.Count(),
                                   }).OrderBy(c => c.count);
                 foreach (var x in charGroups)
                 {
                     if (x.c == 'a' || x.c == 'o' || x.c == 'i' || x.c == 'e')
                     {
                         Console.WriteLine(x.c + ": " + x.count);
                         count = x.count;
                     }
                     else { continue; }
                 }
            }
            void Task1WhithoutLinq()
            {
                
                string str;
                int i, cnt;
                byte firstLetter = 65,  //'A'
                    lastLetter = 90, // 'Z'
                    space = 32; 
                Console.WriteLine("Enter a sentence");
                str = Console.ReadLine();
                char ch;
                for (ch = (char)firstLetter; ch <= lastLetter; ch++)
                {
                    cnt = 0;
                    for (i = 0; i < str.Length; i++)
                    {
                        if (str[i] == 'a' || str[i] == 'o' || str[i] == 'i' || str[i] == 'e')
                        {

                            if (ch == str[i] || (ch + space) == str[i])
                            {
                                cnt++;
                            }
                        }
                        else { continue; }
                    }
                    if (cnt > 0)
                    {
                        Console.WriteLine(ch + "=" + cnt);
                    }
                }
        
            }
            void Task2()
            {
                //task 2
               
                Console.Write("First enter the year: ");

                bool leapYear = false;

                int Year = int.Parse(Console.ReadLine());
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year.", Year);
                    leapYear = true;
                }
                else 
                { 
                    Console.WriteLine("{0} is not a Leap Year.", Year);
                    leapYear = false;
                }
                int month;

                Console.Write("Enter month number: ");
                month = int.Parse(Console.ReadLine());


                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.WriteLine("31 days");
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    //Group all 30 days months together 
                    Console.WriteLine("30 days");
                }
                else if (month == 2)
                {
                    if (leapYear == true)
                    {
                        Console.WriteLine("29 days");
                    }
                    else 
                    {
                        Console.WriteLine("28 days");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter month number between (1-12).");
                }
                
            }
            void Task3()
            {
                //task 3
                Console.WriteLine("Enter 10 int numbers");
                int[] arr = new int[10];
                int sum = 0,
                    prod = 1;


                int length = arr.Length;

                for (int i = 0; i < length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());

                }

                for (int j = 0; j < length / 2; j++)
                {

                    if (arr[j] < 0)
                    {
                        sum = 0;
                        break;
                    }
                    else
                    {
                        sum = sum + arr[j];
                    }
                }

                for (int m = length - 1; m >= length / 2; m--)
                {
                    if (sum > 0)
                    {

                        prod = prod - 1;
                        break;
                    }
                    else
                    {
                        prod = prod * arr[m];
                    }
                }
                if (sum > 0)
                {
                    Console.WriteLine($"sum = {sum}");
                }
                else 
                {
                    Console.WriteLine($"product = {prod}");
                }
               
            }
            void Exiting()
            {
                Console.Write("\n Exiting!....");
                exitPoint = false;
            }
        }
    }
}

