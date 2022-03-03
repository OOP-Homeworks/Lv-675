using System;

namespace HM_6_Mudrak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            void ReadNumber(int start, int end)
            {
                while (a < 10)
                {
                    try
                    {
                        Console.WriteLine("Type number {0}",a + 1);
                        int c = 0;

                        try
                        {
                            c = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        if (c < start || c >= end || c < b)
                        {
                            throw new Exception("Wrong number");
                        }
                        else
                        {
                            b = c;
                            a++;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            Console.WriteLine("Type start num");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type end num");
            int num2 = Int32.Parse(Console.ReadLine());
            b = num1;
            ReadNumber(num1, num2);
            Console.ReadKey();
        }
    }
}
