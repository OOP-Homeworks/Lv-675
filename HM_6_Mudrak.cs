using System;

namespace HM_6_Mudrak
{
    class Program
    {
        static void Main(string[] args)
        {
            a1:
            try
            {
                Console.WriteLine("Type any int number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = Div(num1, num2);

                Console.WriteLine("Type double numbers? y-1 n-2");
                byte check = byte.Parse(Console.ReadLine());
                if (check == 1)
                {
                    double num3 = double.Parse(Console.ReadLine());
                    double num4 = double.Parse(Console.ReadLine());
                    if (Div(num3, num4))
                    {
                        throw new ApplicationException("Double Exeption");
                    }
                }
            } catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Error = {ex.Message}");
                goto a1;
            } catch (FormatException ex)
            {
                Console.WriteLine($"Error = {ex.Message}");
                goto a1;
            }
            Console.ReadKey();

        }
        public static int Div(int num1, int num2)
        {

            return num1 / num2;
        }

        public static bool Div(double num3, double num4)
        {
            double result = num3 / num4;
            bool check = true;
            return check;
        }
    }
}


