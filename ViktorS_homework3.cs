//Read some string str.
//Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.
namespace homeWork3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text");
            string ? text = Console.ReadLine();

            int count = 0;
            foreach (char ch in text)
            {
                if (ch == 'a' || ch == 'o' || ch == 'i' || ch == 'e')
                    count++;
            }

            Console.WriteLine($"Count characters in the text: {count}");
            Console.ReadKey();
        }
    }
}

______________________________________________________________________________

//Ask user to enter the number of month. 
//Read value and output the count of days in this month.
namespace homeWork3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the month");
            int month = Convert.ToInt32(Console.ReadLine());
            var year = DateTime.Today.ToString("yyyy");
            double currentYear = Convert.ToDouble(year);
            int ammount;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 11)
            {
                ammount = 31;
            }
            else if (month == 2)
            {
                if (currentYear % 4 == 0 && (currentYear % 100 != 0 || currentYear % 400 == 0))
                    ammount = 29;
                else
                    ammount = 28;
            }
            else
            {
                ammount = 30;
            }

            Console.WriteLine(ammount);
            Console.ReadKey();
        }
    }
} 

______________________________________________________________________________

//Enter 10 integer numbers.Calculate the sum of first 5 elements if they are positive
//or product of last 5 element in the other case
namespace homeWork3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter the number {i}");
                nums[i] = Convert.ToInt32(Console.ReadLine());            
            }
            Console.WriteLine("\n");

            int sum = 0;
            int prod = 1;
            int countNums = 0;
            bool Mark = true;



            foreach (int x in nums)
            {
                if (countNums < 5)
                {
                    if (x >= 0 && Mark == true)
                    {
                        sum = sum + x;
                    }
                    else
                        Mark = false;
                }
                else
                {
                    if (countNums >= 5)
                    {
                        prod = prod * x;
                    }
                }
                countNums++;

            }

            if (Mark == true)
                Console.WriteLine($"Sum: {sum}");
            else
                Console.WriteLine($"Prod: {prod}");
        }              
    }
}