using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salnikov_HW5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            Console.WriteLine("Etnr pls languages ur programmer: ");
            developers.Add(new Programmer(Console.ReadLine()));
            developers.Add(new Programmer(Console.ReadLine()));
            developers.Add(new Programmer(Console.ReadLine()));

            Console.WriteLine("Ent pls tool ur builder: ");
            developers.Add(new Builder(Console.ReadLine()));
            developers.Add(new Builder(Console.ReadLine()));
            developers.Add(new Builder(Console.ReadLine()));

            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }
            developers.Sort();
            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }
        }
    }
}
