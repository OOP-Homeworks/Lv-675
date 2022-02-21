using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessone6_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int whattype;
            Console.WriteLine("Enter the type of numbers (int - 1, double - 2)");
            whattype = Convert.ToInt32(Console.ReadLine());
            if (whattype == 1)
            {
            begin1:
                try
                {
                    int number1, number2;
                    Console.WriteLine("Enter number 1");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    Div1(number1, number2);
                    Console.WriteLine("Result: " + Div1(number1, number2));
                    if (number1 < number2)
                    {
                        throw new ApplicationException("Second number must be grater than first");
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto begin1;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto begin1;
                }
                finally
                {
                    Console.WriteLine("__________________");
                }
            }
            else if (whattype == 2)
            {
            begin2:
                try
                {
                    double number3, number4;
                    Console.WriteLine("Enter number 1");
                    number3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    number4 = Convert.ToInt32(Console.ReadLine());
                    Div2(number3, number4);
                    Console.WriteLine("Result: " + Div2(number3,number4));
                    if (number3 < number4)
                    {
                        throw new ApplicationException("Second number must be grater than first");
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto begin2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto begin2;
                }
                finally
                {
                    Console.WriteLine("__________________");
                }
            }
            int Div1(int number1, int number2)
            {
                int result = number1 / number2;
                return result;
            }
            double Div2(double number3, double number4)
            {
                double result = number3 / number4;
                return result;
            }
        }
    }
}