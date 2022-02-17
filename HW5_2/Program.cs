using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var somepersons = new SomePersons[7];
            for (int i = 0; i < somepersons.Length; i++)
            {
                somepersons[i] = SomePersons.Input(i);
            }
            Dictionary<uint, string> domains = new Dictionary<uint, string>();
            domains.Add(somepersons[0].Id, somepersons[0].Name);
            domains.Add(somepersons[1].Id, somepersons[1].Name);
            domains.Add(somepersons[2].Id, somepersons[2].Name);
            domains.Add(somepersons[3].Id, somepersons[3].Name);
            domains.Add(somepersons[4].Id, somepersons[4].Name);
            domains.Add(somepersons[5].Id, somepersons[5].Name);
            domains.Add(somepersons[6].Id, somepersons[6].Name);

            Console.WriteLine("Enter the id of SomePerson: ");
            uint id = Convert.ToUInt32(Console.ReadLine());

            for (int i = 0; i < somepersons.Length; i++)
            {
                if (id == somepersons[i].Id)
                {
                    Console.WriteLine("This is a " + somepersons[i].Name);
                }
                else
                {
                    Console.WriteLine("Persone not found :c");
                }
            }
            
        }
    }
}
