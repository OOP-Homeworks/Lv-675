using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_First
{
    class Program
    {
        public static int Div(int a, int b) 
        {
            int result = a / b;
            return result;
        }
        public static bool Div(double a,double  b)
        {
            double result = a / b;
            bool check = true;
            return check;
        }

        static void Main(string[] args)
        {
        a1:
            try
            {
                Console.WriteLine("Enter two int number a & b : ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Do u want entr double numbers? y-1, n-2");
                byte check = byte.Parse(Console.ReadLine());
                if (check == 1)
                {
                    Console.WriteLine("Enter two double number c & d : ");
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    if (Div(c, d)) { throw new ApplicationException("Number can`t be double !"); }
                }
                Console.WriteLine($"{a} / {b} = {Div(a, b)}");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
                goto a1;
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto a1;
            }
            catch (ApplicationException excetption)
            {
                Console.WriteLine(excetption.Message);
                goto a1;
            }
            finally
            {
                Console.WriteLine("Finally !!!\n\n\n");
            }

            
        }
    }

    
}
