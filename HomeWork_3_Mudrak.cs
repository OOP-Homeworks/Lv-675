using System;
using System.Linq;


namespace NomeWork03
{
    class HM3
    {
        static void Main(string[] args)
        {
            string str = @"abcdefoaghroliiikhneeva";
            Console.WriteLine("Напишіть символ:");
            string s = Console.ReadLine();
            int count = str.ToCharArray().Where(c => c == s[0]).Count();
            Console.WriteLine($"кількість вашого символу = {count}");
            Console.ReadKey();

            Console.WriteLine("Введіть номер місяця");
            int month = int.Parse(Console.ReadLine());
            int daysInMonth = DateTime.DaysInMonth(2022, month);
            Console.WriteLine($"{daysInMonth} днів у цьому місяці");

            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // я пройшовся по інтернету і не зміг придумати нічого крім цього :C не знаю як то через масив
                                                             
            for (int i = 0; i < array.Length;)            
            {
                if (array[0] < 0 || array[1] < 0 || array[2] < 0 || array[3] < 0 || array[4] < 0)
                {
                    int multiply = array[5] * array[6] * array[7] * array[8] * array[9];
                    Console.WriteLine("Multiply = {0}", multiply); break;
                } 
                else 
                {
                    int sum = array[0] + array[1] + array[2] + array[3] + array[4];
                    Console.WriteLine("Sum = {0}", sum); break;              
                }
                
            } 

            

        }
    }
}
