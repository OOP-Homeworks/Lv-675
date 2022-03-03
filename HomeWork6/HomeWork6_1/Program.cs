using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Program 
    {
        static void Main(string[] args)
        {
        a1:
            Console.WriteLine("Enter 1 or 2, that choose type for operation(int or double");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1) {   
                try
                { 
                int a, b;
               ;

                    Console.Write("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Div1(a, b);


                if (b > a) { throw new ApplicationException("Second number must be grater than first"); }
               
                } 
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto a1;
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto a1;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto a1;
                }

                finally
                {
                    Console.WriteLine("Congatultions!!! U DONE THIS!!");
                    Console.WriteLine("______________________________");
                }
            }

            if (x == 2)
            {
                try
                {
                    double a1, b1;

                    Console.WriteLine("Enter first number: ");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    b1 = Convert.ToDouble(Console.ReadLine());
                    Div2(a1, b1);
                
                    if (b1 > a1) { throw new ApplicationException("Second number must be grater than first"); }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto a1;
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto a1;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                    goto a1;
                }

                finally
                {
                    Console.WriteLine("Congatultions!!! U DONE THIS!!");
                    Console.WriteLine("______________________________");
                }
            }
        }

        public static int Div1(int a, int b)
        {
            int result = a / b;
            return result;
        }    

        public static double Div2(double a1, double b1)
        {
            double result = a1 / b1;
            return result;
        }
    
    }
}
