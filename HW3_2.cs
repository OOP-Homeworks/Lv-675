using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    enum Month // Creating enum
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
        public static void ExitFromProrgamOrContinue() // Creating method
        {
            Console.WriteLine("Do you want to continue? Yes/No");
            string answer = Console.ReadLine();
            if (answer == "No" || answer == "no")
                Environment.Exit(1);
        }
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Please enter the number of month in range [1-12]: ");
            month = Convert.ToInt32(Console.ReadLine());
            Month countDays = (Month)month; // Using enum
            while (true)
            {
                switch (countDays)
                {
                    case Month.January:
                        Console.WriteLine("There are 31 days in January");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.February:
                        Console.WriteLine("There are 28 days in February");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.March:
                        Console.WriteLine("There are 31 days in March");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.April:
                        Console.WriteLine("There are 30 days in April");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.May:
                        Console.WriteLine("There are 31 days in May");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.June:
                        Console.WriteLine("There are 30 days in June");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.July:
                        Console.WriteLine("There are 31 days in July");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.August:
                        Console.WriteLine("There are 31 days in August");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.September:
                        Console.WriteLine("There are 30 days in September");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.October:
                        Console.WriteLine("There are 31 days in October");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.November:
                        Console.WriteLine("There are 30 days in November");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    case Month.December:
                        Console.WriteLine("There are 31 days in December");
                        Program.ExitFromProrgamOrContinue(); // Using method
                        break;
                    default: // Using deault function for another answers 
                        Console.WriteLine("Wrong input");
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
