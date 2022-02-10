using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2
{
    enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Please enter the number of month in range [1-12]: ");
            month = Convert.ToInt32(Console.ReadLine());
            Month countDays = (Month)month;
            while (true) // made a cycle so that the program can be used as much as you like
            {
                switch (countDays)
                {
                    case Month.January:
                        Console.WriteLine("There are 31 days in January");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.February:
                        Console.WriteLine("There are 28 days in February"); ;
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.March:
                        Console.WriteLine("There are 31 days in March");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.April:
                        Console.WriteLine("There are 30 days in April");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.May:
                        Console.WriteLine("There are 31 days in May");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.June:
                        Console.WriteLine("There are 30 days in June"); ;
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.July:
                        Console.WriteLine("There are 31 days in July");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.August:
                        Console.WriteLine("There are 31 days in August");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.September:
                        Console.WriteLine("There are 30 days in September"); ;
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.October:
                        Console.WriteLine("There are 31 days in October");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.November:
                        Console.WriteLine("There are 30 days in November");
                        ExitFromProgramOrContinueProgram();
                        break;
                    case Month.December:
                        Console.WriteLine("There are 31 days in December");
                        ExitFromProgramOrContinueProgram();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }


        // method that allows you to continue the program or end it
        public static void ExitFromProgramOrContinueProgram()
        {
            Console.WriteLine("Do you want to continue? Print: yes or no!");
            string answer = Console.ReadLine();

            if (answer == "Yes" || answer == "yes")
            {
                Console.WriteLine("Enter number of month");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("There are 31 days in January");
                        break;
                    case 2:
                        Console.WriteLine("There are 28 days in February");
                        break;
                    case 3:
                        Console.WriteLine("There are 31 days in March");
                        break;
                    case 4:
                        Console.WriteLine("There are 30 days in April");
                        break;
                    case 5:
                        Console.WriteLine("There are 31 days in May");
                        break;
                    case 6:
                        Console.WriteLine("There are 30 days in June");
                        break;
                    case 7:
                        Console.WriteLine("There are 31 days in July");
                        break;
                    case 8:
                        Console.WriteLine("There are 31 days in August");
                        break;
                    case 9:
                        Console.WriteLine("There are 30 days in September");
                        break;
                    case 10:
                        Console.WriteLine("There are 31 days in October");
                        break;
                    case 11:
                        Console.WriteLine("There are 30 days in November");
                        break;
                    case 12:
                        Console.WriteLine("There are 31 days in December");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            if (answer == "No" || answer == "no")
            {
                Environment.Exit(0); // function that ends the program
            }
            else
            {
                Console.WriteLine("Wrong input! Input must be yes or no!!!");
            }
        }

        //public static void ExitFromProrgam()
        //{
        //    Console.WriteLine("Do you want to Stop? Yes");
        //    string answer = Console.ReadLine();
        //    if (answer == "Yes" || answer == "yes")
        //        Environment.Exit(1);
        //}
    }

}

