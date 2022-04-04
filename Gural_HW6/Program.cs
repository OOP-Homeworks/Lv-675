using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;
          
            void ReadNumber(int start, int end)
            {
                while(n < 10)
                {
                    try
                    {
                        Console.WriteLine("Enter number {0}",n + 1);
                        int j = 0;
                        
                        try
                        {
                            j = Int32.Parse(Console.ReadLine());
                            
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        
                        if(j <= start || j >= end || j < k)
                        {
                            throw new Exception("invalid number");
                        }
                        
                        else
                        {
                            k = j;
                            n++;

                        }

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            Console.WriteLine("Enter start num");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter finish num");
            int num2 = Int32.Parse(Console.ReadLine());
            k = num1;
            ReadNumber(num1,num2);
            Console.ReadLine();
        }
    }
}
